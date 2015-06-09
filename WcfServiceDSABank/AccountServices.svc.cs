using System;
using System.Linq;
using CommonUtils;
using DataAccess.EntityModel;
using DataAccess.Reposiitories;
using DataAccess.Reposiitories.Accounts;
using WcfServiceDSABank.CurrencyConvertorService;
using WcfServiceDSABank.CustomExceptions;
using Currency = WcfServiceDSABank.CurrencyConvertorService.Currency;

namespace WcfServiceDSABank
{
    public class AccountServices : IAccountServices
    {
        #region Constants

        private const string DefaultCurrency = "EUR";
        private const decimal MinimumBalance = (decimal)10.0;

        #endregion

        #region Properties

        private AccountView From { get; set; }
        private AccountView To { get; set; }

        #endregion

        public void Create(int accountFromId, AccountView item)
        {
            var repo = new AccountsRepo();


            if (accountFromId > 0)
            {
                From = GetAccountDetail(accountFromId);
                To = item;

                if (From.Username == To.Username)
                {
                    decimal balanceFromInEuro = GetRealAmount(From.Currency, DefaultCurrency, From.Balance);
                    decimal balanceToInEuro = GetRealAmount(To.Currency, DefaultCurrency, To.Balance);
                    //deduct amount from source account
                    decimal newFromBalance = Math.Abs(balanceFromInEuro) - Math.Abs(balanceToInEuro);
                    To.Balance = GetRealAmount(DefaultCurrency, To.Currency, balanceToInEuro);
                    if (newFromBalance > MinimumBalance)
                    {
                        From.Balance = GetRealAmount(DefaultCurrency, From.Currency, newFromBalance);
                        bool result = repo.CreateWithSource(From.ID, From.Balance, new Account
                        {
                            Name = To.Name,
                            Remarks = To.Remarks,
                            Currency = To.Currency,
                            Balance = To.Balance,
                            TypeID = To.TypeID,
                            DateOpened = To.DateOpened,
                            Username = To.Username
                        });

                        if (!result)
                        {
                            throw new Exception("Failed to transfer funds");
                        }
                    }
                    else
                    {
                        throw new Exception("Minimum balance exceeded. The minimum balance is Euro 10.");
                    }
                }
                else
                {
                    throw new Exception("The source account must belong to you.");
                }
            }
            else
            {
                var acc = new Account
                {
                    TypeID = item.TypeID,
                    DateOpened = item.DateOpened,
                    Username = item.Username,
                    Name = item.Name,
                    Currency = item.Currency,
                    Balance = item.Balance,
                    Remarks = item.Remarks
                };
                repo.Create(acc);
            }
        }

        public void Delete(int id)
        {
            try
            {
                new AccountsRepo().Delete(new Account { ID = id });
            }
            catch
            {
                throw new DataDeletionException();
            }
        }

        public IQueryable<AccountView> ListUserAccounts(string username)
        {
            return new AccountsRepo().ListByUsername(username).Select(t => new AccountView
            {
                ID = t.ID,
                TypeID = t.TypeID,
                TypeName = t.AccountType.Name,
                DateOpened = t.DateOpened,
                Username = t.Username,
                Name = t.Name,
                Currency = t.Currency,
                Balance = t.Balance,
                Remarks = t.Remarks
            });
        }

        public void Update(AccountView model)
        {
            AccountView item = GetAccountDetail(model.ID);
            new AccountsRepo().Update(new Account
            {
                ID = item.ID,
                TypeID = item.TypeID,
                DateOpened = item.DateOpened,
                Username = item.Username,
                Name = model.Name,
                Currency = item.Currency,
                Balance = item.Balance,
                Remarks = model.Remarks
            });
        }

        public void UpdateFixedAccount(FixedAccountView item)
        {
            new AccountsRepo().Update(new FixedTermAccount
            {
                AccountID = item.ID,
                ExpiryDate = item.ExpiryDate,
                AccumulatedInterest = item.AccumulatedInterest,
                IncomeTaxDeduction = item.IncomeTaxDeduction,
                MaturityAmount = item.MaturityAmount,
                RateID = item.RateID,
                IsExpired = item.IsExpired
            });
        }

        #region Getters

        public AccountView GetAccountDetail(int id)
        {
            Account acc = new AccountsRepo().Read(new Account { ID = id });
            return (new AccountView
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
            });
        }

        public AccountView GetFixedAccount(int id)
        {
            FixedTermAccount acc = new AccountsRepo().GetFixedAccount(id);
            var arrr = new AccountsRepo().Read(new Account() { ID = id });
            if (acc != null)
            {
                return (new AccountView
                {
                    ID = acc.AccountID,
                    TypeID = acc.Account.TypeID,
                    TypeName = acc.Account.AccountType.Name,
                    DateOpened = acc.Account.DateOpened,
                    Username = acc.Account.Username,
                    Name = acc.Account.Name,
                    Currency = acc.Account.Currency,
                    Balance = acc.Account.Balance,
                    Remarks = acc.Account.Remarks,
                    ExpiryDate = acc.ExpiryDate,
                    RateID = acc.RateID,
                    InterestRate = acc.InterestRate.Rate,
                    IncomeTaxDeduction = acc.IncomeTaxDeduction,
                    AccumulatedInterest = acc.AccumulatedInterest,
                    MaturityAmount = acc.MaturityAmount,
                    IsExpired = acc.IsExpired,
                    DurationID = (int)acc.InterestRate.TermID
                });
            }
            return null;
        }

        public IQueryable<AccountTypeView> GetTypes()
        {
            try
            {
                return new AccountTypesRepo().ListAll().Select(u => new AccountTypeView
                {
                    ID = u.ID,
                    Name = u.Name
                });
            }
            catch
            {
                throw new DataListException();
            }
        }

        public IQueryable<FixedAccountView> GetFixedAccounts(string username)
        {
            try
            {
                //3 is id of Term Deposit account type
                var accounts = new AccountsRepo().ListByUsername(username)
                    .Where(u => u.TypeID == 3);
                var result = accounts.Select(t => new FixedAccountView
                        {
                            ID = t.ID,
                            TypeID = t.TypeID,
                            TypeName = t.AccountType.Name,
                            DateOpened = t.DateOpened,
                            Username = t.Username,
                            Name = t.Name,
                            Currency = t.Currency,
                            Balance = t.Balance,
                            Remarks = t.Remarks
                        });

                return result;
            }
            catch
            {
                throw new DataListException();
            }
        }

        public IQueryable<TermView> GetFixedTerms()
        {
            try
            {
                return new FixedTermsRepo().ListAll().OrderBy(e => e.ID).Select(u => new TermView
                {
                    ID = u.ID,
                    Name = u.Duration
                });
            }
            catch
            {
                throw new DataListException();
            }
        }

        public IQueryable<string> GetCurrencyList()
        {
            return new CurrencyRepo().ListAll().Select(c => c.Name).AsQueryable();
        }

        private decimal GetRealAmount(string currencyFrom, string currencyTo, decimal amount)
        {
            decimal result = 0;

            using (var client = new CurrencyConvertorSoapClient("CurrencyConvertorSoap"))
            {
                var from = ConverterUtil.StringToEnum<Currency>(currencyFrom);
                var to = ConverterUtil.StringToEnum<Currency>(currencyTo);
                result = (decimal)client.ConversionRate(from, to) * amount;
            }

            return result;
        }

        #endregion
    }
}