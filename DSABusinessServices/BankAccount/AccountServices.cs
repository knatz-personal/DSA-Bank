using System.Linq;
using DataAccess.EntityModel;
using DataAccess.Reposiitories;
using DataAccess.Reposiitories.Accounts;
using DSABusinessServices.CustomExceptions;

namespace DSABusinessServices.BankAccount
{
    public class AccountServices : IAccountServices
    {
        public AccountView Create(AccountView item)
        {
            var repo = new AccountsRepo();
            var acc = new Account()
            {
                TypeID = item.TypeID,
                DateOpened = item.DateOpened,
                Username = item.Username,
                Name = item.Name,
                ExpiryDate = item.ExpiryDate,
                Currency = item.Currency,
                Balance = item.Balance,
                Remarks = item.Remarks
            };
            repo.Create(acc);
            var result = repo.GetNewAccount(acc);

            return new AccountView()
            {
                ID = result.ID,
                TypeID = result.TypeID,
                DateOpened = result.DateOpened,
                Username = result.Username,
                Name = result.Name,
                ExpiryDate = result.ExpiryDate,
                Currency = result.Currency,
                Balance = result.Balance,
                Remarks = result.Remarks
            };
        }

        public void Delete(int id)
        {
            new AccountsRepo().Delete(new Account {ID = id});
        }

        public AccountView GetAccountDetail(int id)
        {
            Account acc = new AccountsRepo().Read(new Account {ID = id});
            return (new AccountView
            {
                ID = acc.ID,
                TypeID = acc.TypeID,
                TypeName = acc.AccountType.Name,
                DateOpened = acc.DateOpened,
                Username = acc.Username,
                Name = acc.Name,
                ExpiryDate = acc.ExpiryDate,
                Currency = acc.Currency,
                Balance = acc.Balance,
                Remarks = acc.Remarks
            });
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

        public IQueryable<string> GetCurrencyList()
        {
            return new CurrencyRepo().ListAll().Select(c => c.Name).AsQueryable();
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
                ExpiryDate = t.ExpiryDate,
                Currency = t.Currency,
                Balance = t.Balance,
                Remarks = t.Remarks
            });
        }

        public IQueryable<AccountView> ListUserUtilityAccounts(string username)
        {
            return new AccountsRepo().ListByUsername(username).Where(a => a.AccountType.Name == "Utility")
                .Select(t => new AccountView
            {
                ID = t.ID,
                TypeID = t.TypeID,
                TypeName = t.AccountType.Name,
                DateOpened = t.DateOpened,
                Username = t.Username,
                Name = t.Name,
                ExpiryDate = t.ExpiryDate,
                Currency = t.Currency,
                Balance = t.Balance,
                Remarks = t.Remarks
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
    }
}