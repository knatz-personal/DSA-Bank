using System;
using System.Collections.Generic;
using System.Linq;
using CommonUtils;
using DataAccess.EntityModel;
using DataAccess.Reposiitories.Accounts;
using DataAccess.Reposiitories.Transactions;
using WcfServiceDSABank.CurrencyConvertorService;
using WcfServiceDSABank.CustomExceptions;
using Currency = WcfServiceDSABank.CurrencyConvertorService.Currency;
using SortOrder = System.Windows.Forms.SortOrder;

namespace WcfServiceDSABank
{
    public class TransactionServices : ITransactionServices
    {
        #region Constants

        private const string DefaultCurrency = "EUR";
        private const decimal MinimumBalance = (decimal) 10.0;

        #endregion

        #region Properties

        private Account From { get; set; }
        private Account To { get; set; }
        private FixedTermAccount FixedTo { get; set; }

        #endregion

        #region Transfer Funds

        public void TermDeposit(FixedAccountView accountInfo, TransactionView transactionInfo)
        {
            if (transactionInfo.AccountFromID != null && transactionInfo.AccountToID != null)
            {
                if (transactionInfo.AccountFromID != transactionInfo.AccountToID)
                {
                    var repo = new AccountsRepo();
                    int rateId = repo.GetInterestRateId(accountInfo.DurationID);

                    From = GetAccount((int) transactionInfo.AccountFromID);
                    Account temp = GetAccount(accountInfo.ID);

                    if (temp.FixedTermAccount != null && temp.FixedTermAccount.IsExpired != true)
                    {
                        accountInfo.ExpiryDate = temp.FixedTermAccount.ExpiryDate;
                    }

                    FixedTo = repo.CreateFixedAccount(new FixedTermAccount
                    {
                        AccountID = accountInfo.ID,
                        AccumulatedInterest = accountInfo.AccumulatedInterest,
                        IncomeTaxDeduction = accountInfo.IncomeTaxDeduction,
                        MaturityAmount = accountInfo.MaturityAmount,
                        ExpiryDate = accountInfo.ExpiryDate,
                        IsExpired = accountInfo.IsExpired,
                        RateID = rateId
                    });

                    FixedTo.Account = temp;

                    decimal balanceFromInEuro = GetRealAmount(From.Currency, DefaultCurrency, From.Balance);
                    decimal balanceToInEuro = GetRealAmount(FixedTo.Account.Currency, DefaultCurrency,
                        FixedTo.Account.Balance);
                    decimal amountInEuro = GetRealAmount(transactionInfo.Currency, DefaultCurrency,
                        transactionInfo.Amount);
                    //deduct amount from source account
                    decimal newFromBalance = Math.Abs(balanceFromInEuro) - Math.Abs(amountInEuro);
                    //Add amount to destination account
                    decimal newToBalance = Math.Abs(balanceToInEuro) + Math.Abs(amountInEuro);
                    FixedTo.Account.Balance = GetRealAmount(DefaultCurrency, FixedTo.Account.Currency, newToBalance);
                    if (newFromBalance > MinimumBalance)
                    {
                        From.Balance = GetRealAmount(DefaultCurrency, From.Currency, newFromBalance);
                        bool isTransfered = new AccountsRepo().Transfer(From, FixedTo.Account);
                        if (isTransfered)
                        {
                            Log(transactionInfo);
                        }
                        else
                        {
                            throw new TransactionFailedException("Failed to transfer funds.");
                        }
                    }
                    else
                    {
                        throw new Exception("Minimum balance exceeded. The minimum balance is Euro 10.");
                    }
                }
                else
                {
                    throw new Exception("Cannot transfer funds between the same account.");
                }
            }
        }

        public void PersonalTransfer(TransactionView item)
        {
            if (item.AccountFromID != null && item.AccountToID != null)
            {
                if (item.AccountFromID != item.AccountToID)
                {
                    From = GetAccount((int) item.AccountFromID);
                    To = GetAccount((int) item.AccountToID);
                    if (From.TypeID != 1 && To.TypeID != 1)
                    {
                        if (From.Username == To.Username)
                        {
                            decimal balanceFromInEuro = GetRealAmount(From.Currency, DefaultCurrency, From.Balance);
                            decimal balanceToInEuro = GetRealAmount(To.Currency, DefaultCurrency, To.Balance);
                            decimal amountInEuro = GetRealAmount(item.Currency, DefaultCurrency, item.Amount);
                            //deduct amount from source account
                            decimal newFromBalance = Math.Abs(balanceFromInEuro) - Math.Abs(amountInEuro);
                            //Add amount to destination account
                            decimal newToBalance = Math.Abs(balanceToInEuro) + Math.Abs(amountInEuro);
                            To.Balance = GetRealAmount(DefaultCurrency, To.Currency, newToBalance);
                            if (newFromBalance > MinimumBalance)
                            {
                                From.Balance = GetRealAmount(DefaultCurrency, From.Currency, newFromBalance);
                                bool isTransfered = new AccountsRepo().Transfer(From, To);
                                if (isTransfered)
                                {
                                    Log(item);
                                }
                                else
                                {
                                    throw new TransactionFailedException("Failed to transfer funds.");
                                }
                            }
                            else
                            {
                                throw new Exception("Minimum balance exceeded. The minimum balance is Euro 10.");
                            }
                        }
                        else
                        {
                            throw new Exception("Use local transfer to transfer funds to other peoples accounts");
                        }
                    }
                    else
                    {
                        throw new Exception("Use term deposit to transfer funds to fixed term accounts");
                    }
                }
                else
                {
                    throw new Exception("Cannot transfer funds between the same account.");
                }
            }
        }

        public void LocalTransfer(TransactionView item)
        {
            //check that destination account and source account do not belong to the same user
            if (item.AccountFromID != null && item.AccountToID != null)
            {
                if (item.AccountFromID != item.AccountToID)
                {
                    From = GetAccount((int) item.AccountFromID);
                    To = GetAccount((int) item.AccountToID);

                    if (From.Username != To.Username)
                    {
                        if (From.TypeID != 1 && To.TypeID != 1)
                        {
                            decimal balanceFromInEuro = GetRealAmount(From.Currency, DefaultCurrency, From.Balance);
                            decimal balanceToInEuro = GetRealAmount(To.Currency, DefaultCurrency, To.Balance);
                            decimal amountInEuro = GetRealAmount(item.Currency, DefaultCurrency, item.Amount);
                            //deduct amount from source account
                            decimal newFromBalance = Math.Abs(balanceFromInEuro) - Math.Abs(amountInEuro);
                            //Add amount to destination account
                            decimal newToBalance = Math.Abs(balanceToInEuro) + Math.Abs(amountInEuro);
                            To.Balance = GetRealAmount(DefaultCurrency, To.Currency, newToBalance);
                            if (newFromBalance > MinimumBalance)
                            {
                                From.Balance = GetRealAmount(DefaultCurrency, From.Currency, newFromBalance);
                                bool isTransfered = new AccountsRepo().Transfer(From, To);
                                if (isTransfered)
                                {
                                    Log(item);
                                }
                                else
                                {
                                    throw new TransactionFailedException("Failed to transfer funds.");
                                }
                            }
                            else
                            {
                                throw new Exception("Minimum balance exceeded. The minimum balance is Euro 10.");
                            }
                        }
                        else
                        {
                            throw new Exception("Use term deposit to transfer funds to fixed term accounts");
                        }
                    }
                    else
                    {
                        throw new Exception("Use personal transfer to transfer between your own accounts");
                    }
                }
                else
                {
                    throw new Exception("Cannot transfer funds between the same account.");
                }
            }
        }

        #endregion

        public void Delete(int id)
        {
            new TransactionsRepo().Delete(new Transaction {ID = id});
        }

        #region Lists

        public IQueryable<string> ListAccountNumbers()
        {
            IQueryable<string> list = new TransactionsRepo().GetAccountNumbers();
            return list;
        }

        public IQueryable<TransactionView> ListUserTransactions(string username)
        {
            return new TransactionsRepo().ListByUsername(username).Select(t => new TransactionView
            {
                ID = t.ID,
                DateIssued = t.DateIssued,
                TypeID = t.TypeID,
                TypeName = t.TransactionType.Name,
                AccountFromID = t.AccountFromID,
                AccountToID = t.AccountToID,
                Amount = t.Amount,
                Currency = t.Currency,
                Remarks = t.Remarks
            });
        }

        #endregion

        #region Getters

        public TransactionView GetTransactionDetails(int id)
        {
            Transaction t = new TransactionsRepo().Read(new Transaction {ID = id});
            return new TransactionView
            {
                ID = t.ID,
                DateIssued = t.DateIssued,
                TypeID = t.TypeID,
                TypeName = t.TransactionType.Name,
                AccountFromID = t.AccountFromID,
                AccountToID = t.AccountToID,
                Amount = t.Amount,
                Currency = t.Currency,
                Remarks = t.Remarks
            };
        }

        public IEnumerable<TransactionTypeView> GetTransactionTypes()
        {
            return new TransactionTypesRepo().ListAll().Select(g => new TransactionTypeView
            {
                ID = g.ID,
                Name = g.Name
            });
        }

        private decimal GetRealAmount(string currencyFrom, string currencyTo, decimal amount)
        {
            decimal result = 0;

            using (var client = new CurrencyConvertorSoapClient("CurrencyConvertorSoap"))
            {
                var from = ConverterUtil.StringToEnum<Currency>(currencyFrom);
                var to = ConverterUtil.StringToEnum<Currency>(currencyTo);
                result = (decimal) client.ConversionRate(from, to)*amount;
            }

            return result;
        }

        private Account GetAccount(int id)
        {
            Account result = new AccountsRepo().Read(new Account {ID = id});

            return result;
        }

        #endregion

        private void Log(TransactionView item)
        {
            new TransactionsRepo().Create(new Transaction
            {
                DateIssued = item.DateIssued,
                TypeID = item.TypeID,
                Remarks = item.Remarks,
                AccountFromID = item.AccountFromID,
                AccountToID = item.AccountToID,
                Amount = item.Amount,
                Currency = item.Currency
            });
        }

        #region Filters

        public IQueryable<TransactionView> FilterTransactions(string username, int accountNo, SortOrder order,
            DateTime? start, DateTime? end)
        {
            var repo = new TransactionsRepo();

            IQueryable<Transaction> list = null;
            if (!string.IsNullOrEmpty(username) && accountNo > 0)
            {
                list = FilterByUsernameAndAcoount(username, accountNo);
            }
            else if (!string.IsNullOrEmpty(username) && accountNo == 0)
            {
                list = repo.ListByUsername(username);
            }
            else if (string.IsNullOrEmpty(username) && accountNo > 0)
            {
                list = FilterByAccount(accountNo);
            }
            else
            {
                list = repo.ListAll();
            }

            list = ReOrderList(order, list);

            list = FilterByDateRange(start, end, list);

            return list.Select(t => new TransactionView
            {
                ID = t.ID,
                DateIssued = t.DateIssued,
                TypeID = t.TypeID,
                TypeName = t.TransactionType.Name,
                AccountFromID = t.AccountFromID,
                AccountToID = t.AccountToID,
                Amount = t.Amount,
                Currency = t.Currency,
                Remarks = t.Remarks
            });
        }


        private static IQueryable<Transaction> FilterByDateRange(DateTime? start, DateTime? end,
            IQueryable<Transaction> list)
        {
            if (start != null && end != null)
            {
                list = list.Where(apt => apt.DateIssued >= start && apt.DateIssued <= end);
            }
            return list;
        }

        private static IQueryable<Transaction> ReOrderList(SortOrder order, IQueryable<Transaction> list)
        {
            list = order == SortOrder.Ascending
                ? list.OrderBy(a => a.DateIssued)
                : list.OrderByDescending(a => a.DateIssued);
            return list;
        }

        private static IQueryable<Transaction> FilterByAccount(int accountNo)
        {
            IQueryable<Transaction> list =
                new TransactionsRepo().ListAll().Where(a => a.AccountFromID == accountNo || a.AccountToID == accountNo);
            return list;
        }

        private static IQueryable<Transaction> FilterByUsernameAndAcoount(string username, int accountNo)
        {
            IQueryable<Transaction> list =
                new TransactionsRepo().ListByUsername(username)
                    .Where(a => a.AccountFromID == accountNo || a.AccountToID == accountNo);
            return list;
        }

        #endregion
    }
}