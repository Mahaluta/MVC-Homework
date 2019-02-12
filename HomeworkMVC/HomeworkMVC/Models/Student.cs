using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeworkMVC.Models
{
    public class Student
    {
        [Display(Name="Name")]
        public string StudentName { get; set; }
        public int StudentId { get; set; }
        public int StudentAge { get; set; }
        public Standard standard { get; set; }
    }

    public class Standard
    {
        public int StandardId { get; set; }
        public string StandardName { get; set; }
    }
}