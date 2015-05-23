using System.Data;
using System.Transactions;
using CommonUtils;
using DataAccess;
using DataAccess.EntityModel;
using DataAccess.Reposiitories.Accounts;
using DataAccess.Reposiitories.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using DSABusinessServices.BankAccount;
using DSABusinessServices.CurrencyConverterServices;
using DSABusinessServices.CustomExceptions;
using DSABusinessServices.Log;
using Currency = DSABusinessServices.CurrencyConverterServices.Currency;
using Transaction = DataAccess.EntityModel.Transaction;

namespace DSABusinessServices.BankTransaction
{
    public enum SortOrder
    {
        Ascending,
        Descending
    }

    public class TransactionServices : ITransactionServices
    {
        private const string DefaultCurrency = "EUR";
        private const decimal MinimumBalance = (decimal)10.0;
        private AccountView From { get; set; }
        private AccountView To { get; set; }

        private decimal GetRealAmount(string currencyFrom, string currencyTo, decimal amount)
        {
            decimal result = 0;

            using (var client = new CurrencyConvertorSoapClient())
            {
                var from = ConverterUtil.StringToEnum<Currency>(currencyFrom);
                var to = ConverterUtil.StringToEnum<Currency>(currencyTo);
                result = (decimal)client.ConversionRate(from, to) * amount;
            }

            return result;
        }

        private void Log(TransactionView item)
        {
            new TransactionsRepo().Create(new Transaction()
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

        public void TermDeposit(TransactionView item)
        {
            //Deduct from source account
            //Add to destination account
            Log(item);

            throw new NotImplementedException();
        }

        public void PersonalTransafer(TransactionView item)
        {
            if (item.AccountFromID != null && item.AccountToID != null)
            {
                From = GetAccount((int)item.AccountFromID);
                To = GetAccount((int)item.AccountToID);

                using (var ts = new TransactionScope())
                {
                    try
                    {
                        //deduct amount from source account
                        var balanceFromInEuro = GetRealAmount(From.Currency, DefaultCurrency, From.Balance);
                        var balanceToInEuro = GetRealAmount(To.Currency, DefaultCurrency, To.Balance);
                        var amountInEuro = GetRealAmount(item.Currency, DefaultCurrency, item.Amount);

                        decimal newFromBalance = balanceFromInEuro - amountInEuro;
                        if (newFromBalance > MinimumBalance)
                        {
                            From.Balance = GetRealAmount(DefaultCurrency, From.Currency, newFromBalance);
                            Update(new Account
                            {
                                ID = From.ID,
                                TypeID = From.TypeID,
                                DateOpened = From.DateOpened,
                                Username = From.Username,
                                Name = From.Name,
                                Currency = item.Currency,
                                Balance = newFromBalance,
                                Remarks = item.Remarks
                            });
                        }
                        else
                        {
                            throw new Exception("Minimum balance exceeded. The minimum balance is Euro 10.");
                        }

                        //Add amount to destination account
                        decimal newToBalance = balanceToInEuro + amountInEuro;
                        To.Balance = newToBalance;
                        Update(new Account
                        {
                            ID = From.ID,
                            TypeID = From.TypeID,
                            DateOpened = From.DateOpened,
                            Username = From.Username,
                            Name = From.Name,
                            Currency = item.Currency,
                            Balance = newFromBalance,
                            Remarks = item.Remarks
                        });

                        ts.Complete();
                    }
                    catch
                    {
                        ts.Dispose();
                        item.Remarks = "Failed transaction";
                    }
                    finally
                    {
                        Log(item);
                    }
                }
            }
        }

        public void LocalTransfer(TransactionView item)
        {
            //Deduct from source account
            //Add to destination account
            Log(item);
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            new TransactionsRepo().Delete(new Transaction { ID = id });
        }

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

        private static IQueryable<Transaction> FilterByDateRange(DateTime? start, DateTime? end, IQueryable<Transaction> list)
        {
            if (start != null && end != null)
            {
                list = list.Where(apt => apt.DateIssued >= start && apt.DateIssued <= end);
            }
            return list;
        }

        private static IQueryable<Transaction> ReOrderList(SortOrder order, IQueryable<Transaction> list)
        {
            list = order == SortOrder.Ascending ? list.OrderBy(a => a.DateIssued) : list.OrderByDescending(a => a.DateIssued);
            return list;
        }

        private static IQueryable<Transaction> FilterByAccount(int accountNo)
        {
            IQueryable<Transaction> list = new TransactionsRepo().ListAll().Where(a => a.AccountFromID == accountNo || a.AccountToID == accountNo);
            return list;
        }

        private static IQueryable<Transaction> FilterByUsernameAndAcoount(string username, int accountNo)
        {
            IQueryable<Transaction> list = new TransactionsRepo().ListByUsername(username).Where(a => a.AccountFromID == accountNo || a.AccountToID == accountNo);
            return list;
        }

        public TransactionView GetTransactionDetails(int id)
        {
            Transaction t = new TransactionsRepo().Read(new Transaction { ID = id });
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

        private AccountView GetAccount(int id)
        {
            AccountView result = null;
            var acc = new AccountsRepo().Read(new Account() { ID = id });
            result = new AccountView
            {
                ID = acc.ID,
                TypeID = acc.TypeID,
                TypeName = acc.AccountType.Name,
                DateOpened = acc.DateOpened,
                Username = acc.Username,
                Name = acc.Name,
                Currency = acc.Currency,
                Balance = acc.Balance,
                Remarks = acc.Remarks
            };
            return result;
        }

        public IEnumerable<TransactionTypeView> GetTransactionTypes()
        {
            return new TransactionTypesRepo().ListAll().Select(g => new TransactionTypeView
            {
                ID = g.ID,
                Name = g.Name
            });
        }

        public IQueryable<string> ListAccountNumbers()
        {
            var list = new TransactionsRepo().GetAccountNumbers();
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

        private void Update(Account account)
        {
            new AccountsRepo().Update(account);
        }
    }
}