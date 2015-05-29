using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using PagedList;

namespace WebPortal.Models
{
    public class AccountViewModel
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        [Display(Name = "Date Opened")]
        public DateTime DateOpened { get; set; }

        [Display(Name = "Term Expiry")]
        public DateTime? ExpiryDate { get; set; }

        public decimal Balance { get; set; }
        public string Currency { get; set; }

        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public IPagedList<AccountListItemModel> AccountsPagedList { get; set; }
        public int? TypeID { get; set; }
    }

    public class AccountListItemModel
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        [Display(Name = "Type")]
        public int? TypeID { get; set; }

        public string Username { get; set; }

        [Display(Name = "Date Opened")]
        public DateTime DateOpened { get; set; }

        public decimal Balance { get; set; }
        public string Currency { get; set; }

        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        [Display(Name = "Type")]
        public string TypeName { get; set; }
    }

    public class FixedAccountDetailModel
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        [Display(Name = "Type")]
        public int? TypeID { get; set; }

        public string Username { get; set; }

        [Display(Name = "Date Opened")]
        public DateTime DateOpened { get; set; }

        public decimal Balance { get; set; }
        public string Currency { get; set; }

        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        [Display(Name = "Type")]
        public string TypeName { get; set; }

        public decimal? MaturityAmount { get; set; }
        public decimal? IncomeTaxDeduction { get; set; }
        public decimal? AccumulatedInterest { get; set; }
        public int? RateID { get; set; }
        public bool? IsExpired { get; set; }
    }

    public class AccountCreateModel
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = @"Source Account")]
        public int AccFromID { get; set; }

        [Required]
        [Display(Name = @"Starting Balance")]
        [Range(10.00, double.MaxValue, ErrorMessage = @"The minimum starting balance is EUR 10")]
        public decimal Balance { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [RegularExpression("[a-zA-Z]{3}", ErrorMessage = @"A currency value must be 3 character long")]
        public string Currency { get; set; }

        [Required]
        [Display(Name = @"Type")]
        public int? TypeID { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }

        public SelectList Types { get; set; }
        public SelectList Currencies { get; set; }
        public SelectList MyAccounts { get; set; }
    }

    public class AccountEditModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Remarks { get; set; }
    }
}