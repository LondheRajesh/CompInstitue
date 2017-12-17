using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompInstitute.Models
{
    public class Batch
    {
        public string BatchID { get; set; }
        public string CourseID { get; set; }
        public string StaffID { get; set; }
        public int Strength { get; set; }
        public double Time_From { get; set; }
        public double Time_To { get; set; }
        public DateTime StartDate { get; set; }
        public string status { get; set; }
    }
}