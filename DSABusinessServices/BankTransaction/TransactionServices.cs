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
                FilterByUsernameAndAcoount(username, accountNo, repo);
            }
            else if (!string.IsNullOrEmpty(username) && accountNo == 0)
            {
                list = repo.ListByUsername(username);
            }
            else if (string.IsNullOrEmpty(username) && accountNo > 0)
            {
                FilterByAccount(accountNo, repo);
            }
            else
            {
                list = repo.ListAll();
            }

            list = ReOrderList(order, list, repo);

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

        private static IQueryable<Transaction> ReOrderList(SortOrder order, IQueryable<Transaction> list, TransactionsRepo repo)
        {
            if (order == SortOrder.Ascending)
            {
                list = repo.ListAll().OrderBy(a => a.DateIssued);
            }
            else
            {
                list = repo.ListAll().OrderByDescending(a => a.DateIssued);
            }
            return list;
        }

        private static void FilterByAccount(int accountNo, TransactionsRepo repo)
        {
            IQueryable<Transaction> list;
            list = repo.ListAll().Where(a => a.AccountFromID == accountNo || a.AccountToID == accountNo);
        }

        private static void FilterByUsernameAndAcoount(string username, int accountNo, TransactionsRepo repo)
        {
            IQueryable<Transaction> list;
            list =
                repo.ListByUsername(username).Where(a => a.AccountFromID == accountNo || a.AccountToID == accountNo);
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
    }
}