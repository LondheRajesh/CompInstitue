using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompInstitute.Models
{
    public class CourseDetails
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public float Fee { get; set; }
    }
}