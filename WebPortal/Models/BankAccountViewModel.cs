using System;

namespace WebPortal.Models
{
    public class BankAccountViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? TypeID { get; set; }
        public string Username { get; set; }
        public DateTime DateOpened { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal Balance { get; set; }
        public string Currency { get; set; }
        public string Remarks { get; set; }
    }
}