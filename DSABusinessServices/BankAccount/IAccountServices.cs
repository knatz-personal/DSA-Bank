﻿using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace DSABusinessServices.BankAccount
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
        IQueryable<AccountView> GetFixedAccounts(string username);

        [OperationContract]
        IQueryable<TermView> GetFixedTerms();

        [OperationContract]
        IQueryable<string> GetCurrencyList();

        [OperationContract]
        IQueryable<AccountView> ListUserAccounts(string username);

        [OperationContract]
        void Update(AccountView item);
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
        public DateTime? ExpiryDate { get; set; }

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
}