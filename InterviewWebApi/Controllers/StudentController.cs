using InterviewWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InterviewWebApi.Controllers
{
    public class StudentController : ApiController
    {

        IStudent _student;
        public StudentController(IStudent student)
        {
            _student = student;
        }

        [ActionName("GetAllStudent")]
        public IHttpActionResult Get()
        {
            return Ok(_student.GetAllStudents());
        }


        [ActionName("GetStudentByID")]
        public IHttpActionResult Get(int id)
        {
            var student = _student.GetStudent(id);

            if(student == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(student);
            }
        }
    }
}
