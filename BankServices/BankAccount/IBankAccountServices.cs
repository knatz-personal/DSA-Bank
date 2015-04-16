using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BankServices.BankAccount
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBankAccountServices" in both code and config file together.
    [ServiceContract]
    public interface IBankAccountServices
    {
        [OperationContract]
        IQueryable<AccountView> ListUserAccounts(string username);

        [OperationContract]
        IQueryable<AccountView> ListAccounts();

        [OperationContract]
        void Create(AccountView item);

        [OperationContract]
        void Update(AccountView item);

        [OperationContract]
        void Delete(int id);
    }

    [DataContract]
    public class AccountView
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int? TypeID { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public DateTime DateOpened { get; set; }
        [DataMember]
        public DateTime? ExpiryDate { get; set; }
        [DataMember]
        public decimal Balance { get; set; }
        [DataMember]
        public string Currency { get; set; }
        [DataMember]
        public string Remarks { get; set; }
    }
}
