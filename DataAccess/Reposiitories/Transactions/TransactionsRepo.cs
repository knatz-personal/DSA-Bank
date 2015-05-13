using System.Data.Objects.SqlClient;
using System.Globalization;
using System.Linq;
using DataAccess.EntityModel;

namespace DataAccess.Reposiitories.Transactions
{
    public class TransactionsRepo : IDataRepository<Transaction>
    {
        private DsaDataContext _db = new DsaDataContext();

        public IQueryable<Transaction> ListAll()
        {
            return _db.Transactions.AsQueryable();
        }

        public void Create(Transaction newItem)
        {
            _db.Transactions.Add(newItem);
            _db.SaveChanges();
        }

        public Transaction Read(Transaction itemToRead)
        {
            Transaction result = _db.Transactions.Find(itemToRead.ID);
            return result;
        }

        public void Update(Transaction updatedItem)
        {
            var o = _db.Transactions.Find(updatedItem.ID);

            if (o != null)
            {
                o.Remarks = updatedItem.Remarks;
                o.TransactionType = updatedItem.TransactionType;
                o.TypeID = updatedItem.TypeID;
                o.AccountFromID = updatedItem.AccountFromID;
                o.AccountToID = updatedItem.AccountToID;
                o.Amount = updatedItem.Amount;
                o.Currency = updatedItem.Currency;
                o.DateIssued = updatedItem.DateIssued;
                
                _db.SaveChanges();
            }
        }

        public void Delete(Transaction itemToDelete)
        {
            var o = _db.Transactions.Find(itemToDelete.ID);

            if (o != null)
            {
                _db.Transactions.Remove(o);
                _db.SaveChanges();
            }
        }

        public IQueryable<Transaction> ListByUsername(string username)
        {
            return _db.Transactions.Where(t => t.Account.Username == username || t.Account1.Username == username);
        }

        public IQueryable<Transaction> ListByAccountNumber(int accountNo)
        {
            return _db.Transactions.Where(t => t.Account.ID == accountNo || t.Account1.ID == accountNo);
        }

        public IQueryable<string> GetAccountNumbers()
        {
            return _db.Accounts.Select(u => SqlFunctions.StringConvert((double)u.ID).Trim()).AsQueryable();
        }
    }
}