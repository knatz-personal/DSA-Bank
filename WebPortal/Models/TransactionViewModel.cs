using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using PagedList;

namespace WebPortal.Models
{
    public class TransactionViewModel
    {
        [Required]
        [Display(Name = @"Account")]
        public int? AccountToListID { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        public IPagedList<TransactionListItemModel> TransactionsPagedList { get; set; }
        public IEnumerable<TransactionListItemModel> TransactionsList { get; set; }

        public IEnumerable<SelectListItem> MyAccounts { get; set; }
    }

    public class TransactionListItemModel
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

        [Display(Name = "Type")]
        public string TypeName { get; set; }
    }

    public class TransactionDetailModel
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = @"Transaction Date")]
        [DataType(DataType.DateTime)]
        public DateTime DateIssued { get; set; }

        [Display(Name = "Transaction Type")]
        public string TypeName { get; set; }


        [Display(Name = @"Account From")]
        public int? AccountFromID { get; set; }

        [Display(Name = @"Account To")]
        public int? AccountToID { get; set; }

        public string Currency { get; set; }

        public decimal Amount { get; set; }

        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }
    }
    
    public class TransactionModel
    {
        [Key]
        public int ID { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.DateTime)]
        public DateTime DateIssued { get; set; }

        [Required]
        [Display(Name = @"Type")]
        public int? TypeID { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        [Required]
        [Display(Name = @"Account From")]
        public int? AccountFromID { get; set; }

        [Required]
        [Display(Name = @"Account To")]
        public int? AccountToID { get; set; }

        [Required]
        public string Currency { get; set; }

        [Required]
        [Range(10,double.MaxValue,ErrorMessage = "The minimum starting balance is EUR 10")]
        public decimal Amount { get; set; }

        public SelectList Types { get; set; }
        public IEnumerable<SelectListItem> MyAccounts { get; set; }
        public IEnumerable<SelectListItem> UtilityAccounts { get; set; }
        public SelectList Currencies { get; set; }
    }
}