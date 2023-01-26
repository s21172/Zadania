using Microsoft.AspNetCore.Mvc;
using Zad3.Models;
using Zad3.Services;
using Zad3.Utils;

namespace Zad3.Controllers

{
    [ApiController]
    [Route("api/students")]
    public class StudentController : Controller
    {
        private readonly ICSVService _csvService;

        public StudentController(ICSVService csvService)
        {
            _csvService = csvService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddStudent([FromBody] Student student)
        {
            try
            {
                _csvService.Add(student);
                return Ok(student);
            }
            catch(InvalidDataException ed)
            {
                return BadRequest(ed.Message);
            }
            catch (StudentDuplicatedException de)
            {
                return Conflict(de.Message);
            }
            catch (BadHttpRequestException re)
            {
                return BadRequest(re.Message);
            }

        }

        [HttpPut("{studentId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> EditStudent([FromRoute] string studentId, [FromBody] Student newStudentData)
        {
            try
            {
                _csvService.Edit(studentId, newStudentData);
                return Ok(newStudentData);
            }
            catch (FileNotFoundException fe)
            {
                return BadRequest(fe.Message);
            }
            catch (StudentException se)
            {
                return BadRequest(se.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpGet("{studentId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetStudentById([FromRoute] string studentId)
        {
            try
            {
                var student = _csvService.GetByID(studentId);
                return Ok(student);
            }
            catch (FileNotFoundException fe)
            {
                return BadRequest(fe.Message);
            }
            catch (StudentException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            try
            {
                var Students = _csvService.GetAll();
                return Ok(Students);
            }
            catch (FileNotFoundException ex)
            {
                return Ok(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("{studentId}")]
        public async Task<IActionResult> DeleteStudent([FromRoute] string studentId)
        {
            try
            {
                _csvService.Remove(studentId);
                return Ok("Student o numerze indeksu: \"" + studentId + "\" zostal usuniety");
            }
            catch (FileNotFoundException  fe)
            {
                return BadRequest(fe.Message);
            }
            catch (StudentException se)
            {
                return BadRequest(se.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}