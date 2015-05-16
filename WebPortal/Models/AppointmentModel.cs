using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Mvc;

namespace WebPortal.Models
{
    public class AppointmentModel
    {
        [Key]
        public int ID { get; set; }

        [ScaffoldColumn(false)]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.DateTime)]
        public DateTime SuggestedDate { get; set; }

        [Required]
        [Display(Name = "Time")]
        [DataType(DataType.Time)]
        public string SuggestedTime { get; set; }

        [Required]
        [DataType(DataType.Duration)]
        public string Duration { get; set; }
        
        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [ScaffoldColumn(false)]
        public bool? IsAccepted { get; set; }

        public SelectList DurationValues { get; set; }
    }
}