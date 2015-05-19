using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using PagedList;
using WebPortal.CustomValidators;

namespace WebPortal.Models
{
    public class DepositModel
    {
        [Required]
        [Display(Name = @"Account To")]
        [NotEqualTo("AccountToID", ErrorMessage = "Cannot transafer funds to or from the same account")]
        public int? AccountToID { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "The minimum transaction amount is EUR 0.01")]
        public decimal Amount { get; set; }

        [Required]
        public string Currency { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.DateTime)]
        public DateTime DateIssued { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        [Display(Name = @"Type")]
        public int? TypeID { get; set; }

        public SelectList MyAccounts { get; set; }
        public SelectList Currencies { get; set; }
    }

    public class TransactionDetailModel
    {
        [Display(Name = @"Account From")]
        public int? AccountFromID { get; set; }

        [Display(Name = @"Account To")]
        public int? AccountToID { get; set; }

        public decimal Amount { get; set; }

        public string Currency { get; set; }

        [Display(Name = @"Transaction Date")]
        [DataType(DataType.DateTime)]
        public DateTime DateIssued { get; set; }

        [Key]
        public int ID { get; set; }
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        [Display(Name = "Transaction Type")]
        public string TypeName { get; set; }
    }

    public class TransactionListItemModel
    {
        [Required]
        [Display(Name = @"Acc From")]
        public int? AccountFromID { get; set; }

        [Required]
        [Display(Name = @"Acc To")]
        public int? AccountToID { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string Currency { get; set; }

        [Required]
        [Display(Name = @"Date")]
        [DataType(DataType.DateTime)]
        public DateTime DateIssued { get; set; }

        [Key]
        public int ID { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        [Required]
        [Display(Name = @"Type")]
        public int? TypeID { get; set; }
        [Display(Name = "Type")]
        public string TypeName { get; set; }
    }

    public class TransactionViewModel
    {
        [Required]
        [Display(Name = @"Account")]
        public int? AccountToListID { get; set; }

        [Required]
        [Display(Name = "End Date")]
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        public IEnumerable<SelectListItem> MyAccounts { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }
        public IEnumerable<TransactionListItemModel> TransactionsList { get; set; }

        public IPagedList<TransactionListItemModel> TransactionsPagedList { get; set; }
    }

    public class TransferOtherModel
    {
        [Required]
        [Display(Name = @"Account From")]
        [NotEqualTo("AccountToID", ErrorMessage = "Cannot transafer funds to or from the same account")]
        public int? AccountFromID { get; set; }

        [Required]
        [Display(Name = @"Account To")]
        [NotEqualTo("AccountToID", ErrorMessage = "Cannot transafer funds to or from the same account")]
        public int? AccountToID { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "The minimum transaction amount is EUR 0.01")]
        public decimal Amount { get; set; }

        [Required]
        public string Currency { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.DateTime)]
        public DateTime DateIssued { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = @"Type")]
        public int? TypeID { get; set; }

        public SelectList MyAccounts { get; set; }
        public SelectList Currencies { get; set; }
    }

    public class TransferOwnModel
    {
        [Required]
        [Display(Name = @"Account From")]
        [NotEqualTo("AccountToID", ErrorMessage = "Cannot transafer funds to or from the same account")]
        public int? AccountFromID { get; set; }

        [Required]
        [Display(Name = @"Account To")]
        [NotEqualTo("AccountFromID", ErrorMessage = "Cannot transafer funds to or from the same account")]
        public int? AccountToID { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "The minimum transaction amount is EUR 0.01")]
        public decimal Amount { get; set; }


        [Required]
        public string Currency { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.DateTime)]
        public DateTime DateIssued { get; set; }

        [Key]
        public int ID { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = @"Type")]
        public int? TypeID { get; set; }

        public SelectList MyAccounts { get; set; }
        public SelectList Currencies { get; set; }
    }
}