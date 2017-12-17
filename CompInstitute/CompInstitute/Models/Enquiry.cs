using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompInstitute.Models
{
    public class Enquiry
    {
        public string FullName { get; set; }
        public string EmailID { get; set; }
        public string MobileNo { get; set; }
        public string EnqMessage { get; set; }
        public DateTime EnqDate { get; set; }
        public string status { get; set; }
    }
}