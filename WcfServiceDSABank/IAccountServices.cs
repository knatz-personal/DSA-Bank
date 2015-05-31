using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfServiceDSABank
{
    [ServiceContract]
    public interface IAccountServices
    {
        [OperationContract]
        void Create(int accountFromId, AccountView item);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        AccountView GetAccountDetail(int id);

        [OperationContract]
        IQueryable<AccountTypeView> GetTypes();

        [OperationContract]
        IQueryable<FixedAccountView> GetFixedAccounts(string username);

        [OperationContract]
        IQueryable<TermView> GetFixedTerms();

        [OperationContract]
        IQueryable<string> GetCurrencyList();

        [OperationContract]
        IQueryable<AccountView> ListUserAccounts(string username);

        [OperationContract]
        void Update(AccountView item);

        [OperationContract]
        void UpdateFixedAccount(FixedAccountView item);
    }

    [DataContract]
    public class AccountTypeView
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }
    }

    [DataContract]
    public class TermView
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }
    }

    [DataContract]
    public class AccountView
    {
        [DataMember]
        public decimal Balance { get; set; }

        [DataMember]
        public string Currency { get; set; }

        [DataMember]
        public DateTime DateOpened { get; set; }

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Remarks { get; set; }

        [DataMember]
        public int? TypeID { get; set; }

        [DataMember]
        public string TypeName { get; set; }

        [DataMember]
        public string Username { get; set; }
    }

    [DataContract]
    public class FixedAccountView
    {
        [DataMember]
        public decimal Balance { get; set; }

        [DataMember]
        public string Currency { get; set; }

        [DataMember]
        public DateTime DateOpened { get; set; }

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Remarks { get; set; }

        [DataMember]
        public int? TypeID { get; set; }

        [DataMember]
        public string TypeName { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public decimal? MaturityAmount { get; set; }

        [DataMember]
        public decimal? IncomeTaxDeduction { get; set; }

        [DataMember]
        public decimal? AccumulatedInterest { get; set; }

        [DataMember]
        public int? RateID { get; set; }

        [DataMember]
        public decimal InterestRate { get; set; }

        [DataMember]
        public int DurationID { get; set; }

        [DataMember]
        public bool? IsExpired { get; set; }

        [DataMember]
        public DateTime ExpiryDate { get; set; }
    }
}