using System.Linq;
using DataAccess.EntityModel;
using DataAccess.Reposiitories.Accounts;

namespace BankServices.BankAccount
{
    public class BankAccountServices : IBankAccountServices
    {
        public IQueryable<AccountView> ListUserAccounts(string username)
        {
            return new AccountsRepo().ListByUsername(username).Select(t => new AccountView
            {
                ID = t.ID,
                TypeID = t.TypeID,
                DateOpened = t.DateOpened,
                Username = t.Username,
                Name = t.Name,
                ExpiryDate = t.ExpiryDate,
                Currency = t.Currency,
                Balance = t.Balance,
                Remarks = t.Remarks
            });
        }

        public IQueryable<AccountView> ListAccounts()
        {
            return new AccountsRepo().ListAll().Select(t => new AccountView
            {
                ID = t.ID,
                TypeID = t.TypeID,
                DateOpened = t.DateOpened,
                Username = t.Username,
                Name = t.Name,
                ExpiryDate = t.ExpiryDate,
                Currency = t.Currency,
                Balance = t.Balance,
                Remarks = t.Remarks
            });
        }

        public void Create(AccountView item)
        {
            new AccountsRepo().Create(new Account
            {
                ID = item.ID,
                TypeID = item.TypeID,
                DateOpened = item.DateOpened,
                Username = item.Username,
                Name = item.Name,
                ExpiryDate = item.ExpiryDate,
                Currency = item.Currency,
                Balance = item.Balance,
                Remarks = item.Remarks
            });
        }

        public void Update(AccountView item)
        {
            new AccountsRepo().Update(new Account
            {
                ID = item.ID,
                TypeID = item.TypeID,
                DateOpened = item.DateOpened,
                Username = item.Username,
                Name = item.Name,
                ExpiryDate = item.ExpiryDate,
                Currency = item.Currency,
                Balance = item.Balance,
                Remarks = item.Remarks
            });
        }

        public void Delete(int id)
        {
            new AccountsRepo().Delete(new Account {ID = id});
        }
    }
}