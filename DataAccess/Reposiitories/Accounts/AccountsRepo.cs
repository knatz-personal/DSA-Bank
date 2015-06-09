using System;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Transactions;
using DataAccess.EntityModel;

namespace DataAccess.Reposiitories.Accounts
{
    public class AccountsRepo : IDataRepository<Account>
    {
        private readonly DsaDataContext _db = new DsaDataContext();

        public void Create(Account newItem)
        {
            _db.Accounts.Add(newItem);
            _db.SaveChanges();
        }

        public void Delete(Account itemToDelete)
        {
            Account o = _db.Accounts.Find(itemToDelete.ID);

            if (o != null)
            {
                _db.Accounts.Remove(o);
                _db.SaveChanges();
            }
        }

        public IQueryable<Account> ListAll()
        {
            return _db.Accounts.AsQueryable();
        }

        public Account Read(Account itemToRead)
        {
            Account result = _db.Accounts.Find(itemToRead.ID);
            return result;
        }

        public void Update(Account updatedItem)
        {
            Account o = _db.Accounts.Find(updatedItem.ID);

            if (o != null)
            {
                o.Remarks = updatedItem.Remarks;
                o.Name = updatedItem.Name;
                _db.SaveChanges();
            }
        }

        public void Update(FixedTermAccount updatedItem)
        {
            FixedTermAccount o = _db.FixedTermAccounts.Find(updatedItem.AccountID);

            if (o != null)
            {
                o.AccumulatedInterest = updatedItem.AccumulatedInterest;
                o.IncomeTaxDeduction = updatedItem.IncomeTaxDeduction;
                o.ExpiryDate = updatedItem.ExpiryDate;
                o.IsExpired = updatedItem.IsExpired;
                o.MaturityAmount = updatedItem.MaturityAmount;
                o.RateID = updatedItem.RateID;
                _db.SaveChanges();
            }
        }

        public bool CreateWithSource(int accountFromId, decimal newAccountFromBalance, Account accountTo)
        {
            bool result = false;
            using (var ts = new TransactionScope())
            {
                using (var context = new DsaDataContext())
                {
                    context.Database.Connection.Open();
                    try
                    {
                        Account from = context.Accounts.Find(accountFromId);
                        from.Balance = newAccountFromBalance;

                        if (accountTo.TypeID != 1){
                            context.Accounts.Add(accountTo);
                        }
                        else
                        {
                            context.Accounts.Add(accountTo);
                            context.FixedTermAccounts.Add(new FixedTermAccount()
                            {
                                AccountID = accountTo.ID,
                                AccumulatedInterest = 0,
                                ExpiryDate = DateTime.MinValue,
                                IncomeTaxDeduction = 0,
                                IsExpired = true,
                                MaturityAmount = 0,
                                RateID = 1
                            });
                        }

                        context.SaveChanges();
                        ts.Complete();
                        result = true;
                    }
                    catch
                    {
                        ts.Dispose();
                    }
                    finally
                    {
                        if (context.Database.Connection.State == ConnectionState.Open)
                        {
                            context.Database.Connection.Close();
                        }
                    }
                }
            }
            return result;
        }

        public FixedTermAccount CreateFixedAccount(FixedTermAccount newItem)
        {
            FixedTermAccount result = null;

            _db.FixedTermAccounts.AddOrUpdate(newItem);
            _db.SaveChanges();
            result = _db.FixedTermAccounts.Find(newItem.AccountID);

            return result;
        }

        public void Renew(FixedTermAccount updatedItem)
        {
            FixedTermAccount o = _db.FixedTermAccounts.Find(updatedItem.AccountID);

            if (o != null)
            {
                o.IsExpired = updatedItem.IsExpired;
                o.RateID = updatedItem.RateID;

                _db.SaveChanges();
            }
        }


        public bool Transfer(Account accountFrom, Account accountTo)
        {
            bool result = false;

            using (var ts = new TransactionScope())
            {
                using (var context = new DsaDataContext())
                {
                    context.Database.Connection.Open();
                    try
                    {
                        if (accountFrom != null && accountTo != null)
                        {
                            Account from = context.Accounts.Find(accountFrom.ID);
                            from.Balance = accountFrom.Balance;

                            Account to = context.Accounts.Find(accountTo.ID);
                            to.Balance = accountTo.Balance;

                            context.SaveChanges();
                            ts.Complete();
                            result = true;
                        }
                    }
                    catch
                    {
                        ts.Dispose();
                    }
                    finally
                    {
                        if (context.Database.Connection.State == ConnectionState.Open)
                        {
                            context.Database.Connection.Close();
                        }
                    }
                }
            }

            return result;
        }

        public IQueryable<Account> ListByUsername(string username)
        {
            return _db.Accounts.Where(a => a.Username == username);
        }

        public FixedTermAccount GetFixedAccount(int id)
        {
            FixedTermAccount result = _db.FixedTermAccounts.SingleOrDefault(acc=> acc.Account.ID == id);
            return result;
        }

        public int GetInterestRateId(int durationId)
        {
            InterestRate result = _db.InterestRates.SingleOrDefault(r => r.TermID == durationId);

            return result == null ? 0 : result.ID;
        }
    }
}