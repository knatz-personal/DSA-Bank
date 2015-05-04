using System.Collections.Generic;
using System.Linq;
using DataAccess.EntityModel;
using DataAccess.Reposiitories.Transactions;

namespace BankServices.BankTransaction
{
    public class TransactionServices : ITransactionServices
    {
        public IQueryable<TransactionView> ListTransactions()
        {
            return new TransactionsRepo().ListAll().Select(t => new TransactionView
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

        public TransactionView GetTransactionDetails(int id)
        {
            var t = new TransactionsRepo().Read(new Transaction() {ID = id});
            return  new TransactionView
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

        public void Create(TransactionView item)
        {
            new TransactionsRepo().Create(new Transaction
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
            new TransactionsRepo().Update(new Transaction
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
            new TransactionsRepo().Delete(new Transaction {ID = id});
        }
    }
}