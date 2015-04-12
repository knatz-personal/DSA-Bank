using System.Linq;
using DataAccess.EntityModel;
using DataAccess.Reposiitories;

namespace BankServices.BankTransaction
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TransactionServices" in both code and config file together.
    public class TransactionServices : ITransactionServices
    {
        public IQueryable<TransactionView> ListTransactions()
        {
            return new TransactionsRepo().ListAll().Select(t=>new TransactionView()
            {
                ID = t.ID,
                DateIssued = t.DateIssued,
                TypeID = t.TypeID,
                AccountFromID = t.AccountFromID,
                AccountToID = t.AccountToID,
                Amount = t.Amount,
                Currency = t.Currency,
                Remarks = t.Remarks
            });
        }

        public IQueryable<TransactionView> ListUserTransactions(string username)
        {
            return new TransactionsRepo().ListByUsername(username).Select(t => new TransactionView()
            {
                ID = t.ID,
                DateIssued = t.DateIssued,
                TypeID = t.TypeID,
                AccountFromID = t.AccountFromID,
                AccountToID = t.AccountToID,
                Amount = t.Amount,
                Currency = t.Currency,
                Remarks = t.Remarks
            });
        }

        //public void Deposit(TransactionView item)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Transfer(TransactionView item)
        //{
        //    throw new NotImplementedException();
        //}

        //public void PayBill(TransactionView item)
        //{
        //    throw new NotImplementedException();
        //}

        public void Create(TransactionView item)
        {
            new TransactionsRepo().Create(new TransactionLog()
            {
                ID = item.ID,
                DateIssued = item.DateIssued,
                TypeID = item.TypeID,
                AccountFromID = item.AccountFromID,
                AccountToID = item.AccountToID,
                Amount = item.Amount,
                Currency = item.Currency,
                Remarks = item.Remarks
            });
        }

        public void Update(TransactionView item)
        {
            new TransactionsRepo().Update(new TransactionLog()
            {
                ID = item.ID,
                DateIssued = item.DateIssued,
                TypeID = item.TypeID,
                AccountFromID = item.AccountFromID,
                AccountToID = item.AccountToID,
                Amount = item.Amount,
                Currency = item.Currency,
                Remarks = item.Remarks
            });
        }

        public void Delete(int id)
        {
           new TransactionsRepo().Delete(new TransactionLog(){ID = id});
        }
    }
}
