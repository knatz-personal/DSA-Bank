using System;
using System.ComponentModel.DataAnnotations;

namespace WebPortal.Models
{
    public class BankAccountViewModel
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name ="Type")]
        public int? TypeID { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [Display(Name = "Date Opened")]
        public DateTime DateOpened { get; set; }
        [Display(Name = "Expiry Date")]
        public DateTime? ExpiryDate { get; set; }
        [Required]
        public decimal Balance { get; set; }
        [Required]
        public string Currency { get; set; }
        public string Remarks { get; set; }
    }
}