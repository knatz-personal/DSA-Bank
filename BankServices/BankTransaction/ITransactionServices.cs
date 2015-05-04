using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace BankServices.BankTransaction
{
    [ServiceContract]
    public interface ITransactionServices
    {
        [OperationContract]
        IQueryable<TransactionView> ListTransactions();

        [OperationContract]
        IQueryable<TransactionView> ListUserTransactions(string username);

        [OperationContract]
        TransactionView GetTransactionDetails(int id);

        [OperationContract]
        IEnumerable<TransactionTypeView> GetTransactionTypes();

        //[OperationContract]
        //void Deposit(TransactionView item);

        //[OperationContract]
        //void Transfer(TransactionView item);

        //[OperationContract]
        //void PayBill(TransactionView item);

        [OperationContract]
        void Create(TransactionView item);

        [OperationContract]
        void Update(TransactionView item);

        [OperationContract]
        void Delete(int id);
    }

    [DataContract]
    public class TransactionView
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int? AccountFromID { get; set; }

        [DataMember]
        public int? AccountToID { get; set; }

        [DataMember]
        public int? TypeID { get; set; }

        [DataMember]
        public string TypeName { get; set; }

        [DataMember]
        public DateTime DateIssued { get; set; }

        [DataMember]
        public decimal Amount { get; set; }

        [DataMember]
        public string Currency { get; set; }

        [DataMember]
        public string Remarks { get; set; }
    }

    [DataContract]
    public class TransactionTypeView
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}