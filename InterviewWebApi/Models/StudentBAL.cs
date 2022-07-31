using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewWebApi.Models
{
    public class StudentBAL : IStudent
    {

        List<Student> studentLists = new List<Student>()
        {
            new Student(){ID = 1, FirstName="Collins", LastName="Frimpong", Email="fcollinz@gmail.com"},
             new Student(){ID = 2, FirstName="Brolin", LastName="Agyapong", Email="agyapong@gmail.com"},
              new Student(){ID = 3, FirstName="Agyemang", LastName="Boamah", Email="Boamah@gmail.com"}
        };

        public List<Student> GetAllStudents()
        {
            return studentLists; 
        }

        public Student GetStudent(int id)
        {
            return studentLists.FirstOrDefault(x=>x.ID == id);
        }


    }
}