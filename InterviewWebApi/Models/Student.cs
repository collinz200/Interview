using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewWebApi.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}