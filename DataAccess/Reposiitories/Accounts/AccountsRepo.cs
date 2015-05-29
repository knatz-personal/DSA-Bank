﻿using System;
using System.Data;
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
                        var from = context.Accounts.Find(accountFromId);
                        from.Balance = newAccountFromBalance;

                        context.Accounts.Add(accountTo);
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

        public void CreateFixedAccount(FixedTermAccount newItem)
        {
            _db.FixedTermAccounts.Add(newItem);
            _db.SaveChanges();
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
                            var from = context.Accounts.Find(accountFrom.ID);
                            from.Balance = accountFrom.Balance;

                            var to = context.Accounts.Find(accountTo.ID);
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

        public Account GetNewAccount(Account acc)
        {
            return _db.Accounts.Where(u => u.Username == acc.Username).SingleOrDefault(a => a.TypeID == acc.TypeID && a.DateOpened == acc.DateOpened);
        }
    }
}