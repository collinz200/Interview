using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewWebApi.Models
{
    public interface IStudent
    {
         List<Student> GetAllStudents();
         Student GetStudent(int id);

    }
}
