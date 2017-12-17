using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompInstitute.Models
{
    public class StaffProfile
    {
        public string StaffID { get; set; }
        public string FullName { get; set; }
        public string EmailID { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public DateTime JoiningDate { get; set; }
        public string status { get; set; }
        public string Password { get; set; }
    }
}