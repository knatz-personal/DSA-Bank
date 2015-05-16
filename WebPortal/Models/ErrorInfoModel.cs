using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPortal.Models
{
    public class ErrorInfoModel
    {
        public int HttpStatusCode { get; set; }
        public Exception Exception { get; set; }
        public string StatusDescription { get; set; }
    }
}