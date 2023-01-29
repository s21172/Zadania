using BlazorClientSideSamples.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlazorClientSideSamples.Server.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private static List<Student2> _students = new List<Student2>();

        static StudentsController()
        {
            _students.Add(new Student2
            {
                IdStudent = 1,
                FirstName = "Jan",
                LastName = "Kowalski"
            });
            _students.Add(new Student2
            {
                IdStudent = 2,
                FirstName = "Anna",
                LastName = "Malewska"
            });
            _students.Add(new Student2
            {
                IdStudent = 3,
                FirstName = "Andrzej",
                LastName = "Andrzejewski"
            });
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_students);
        }

    }
}
