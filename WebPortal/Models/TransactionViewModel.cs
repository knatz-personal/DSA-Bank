using System;
using System.ComponentModel.DataAnnotations;

namespace WebPortal.Models
{
    public class TransactionViewModel
    {
        [Key]
        public int ID { get; set; }
        
        [Required]
        [Display(Name = @"Date")]
        [DataType(DataType.DateTime)]
        public DateTime DateIssued { get; set; }

        [Required]
        [Display(Name = @"Type")]
        public int? TypeID { get; set; }
        
        [Required]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        [Required]
        [Display(Name = @"Acc From")]
        public int? AccountFromID { get; set; }

        [Required]
        [Display(Name = @"Acc To")]
        public int? AccountToID { get; set; }

        [Required]
        public string Currency { get; set; }

        [Required]
        public decimal Amount { get; set; }


    }
}