using DataAccess.EntityModel;
using DataAccess.Reposiitories.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DSABusinessServices.BankTransaction
{
    public enum SortOrder
    {
        Ascending,
        Descending
    }

    public class TransactionServices : ITransactionServices
    {
        public void Create(TransactionView item)
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
    }
}