using BlazorWebHomeworkAPI.DataControllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using BlazorWebHomework.Models;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Data.Common;


namespace BlazorWebHomeworkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly StudentDataController _studentDataController;

        public StudentController(IConfiguration configuration)
        {
            _studentDataController = new StudentDataController(configuration);
        }

        [HttpGet("GetAllStudents")]
        public IActionResult GetAllStudents(string? searchText = null)
        {
            try
            {
                var students = _studentDataController.GetAllStudents(searchText);
                return Ok(students);
            }
            catch (SqlException ex)
            {
                Log.Error("Problem with database. Message: " + ex.Message + " Stack calls: " + ex.StackTrace);
                return BadRequest("Problem with database");
            }
            catch (Exception ex)
            {
                Log.Error("Exception. Message: " + ex.Message + " Stack calls: " + ex.StackTrace);
                return BadRequest();
            }
        }

        [HttpGet("GetStudentById")]
        public IActionResult GetStudentById(int studentId)
        {
            try
            {
                var student = _studentDataController.GetStudentById(studentId);
                return Ok(student);
            }
            catch (SqlException ex)
            {
                Log.Error("Problem with database. Message: " + ex.Message + " Stack calls: " + ex.StackTrace);

                return BadRequest("Problem with database");
            }
            catch (Exception ex)
            {
                Log.Error("Exception. Message: " + ex.Message + " Stack calls: " + ex.StackTrace);
                return BadRequest();
            }
        }

        [HttpPost("CreateStudent")]
        public IActionResult CreateStore(Student student)
        {
            try
            {
                var result = _studentDataController.CreateStudent(student);
                if (result == 0) return BadRequest(new { Message = "Student was not created" });
                return Ok(result);
            }
            catch (SqlException ex)
            {
                Log.Error("Problem with database. Message: " + ex.Message + " Stack calls: " + ex.StackTrace);
                return BadRequest("Problem with database");
            }
            catch (Exception ex)
            {
                Log.Error("Exception. Message: " + ex.Message + " Stack calls: " + ex.StackTrace);
                return BadRequest();
            }
        }

        [HttpPut("UpdateStudent")]
        public IActionResult UpdateStudent(Student student)
        {
            try
            {
                var result = _studentDataController.UpdateStudent(student);
                if (result == 0) return BadRequest(new { Message = "Student was not updated" });
                return Ok(result);
            }
            catch (SqlException ex)
            {
                Log.Error("Problem with database. Message: " + ex.Message + " Stack calls: " + ex.StackTrace);
                return BadRequest("Problem with database");
            }
            catch (Exception ex)
            {
                Log.Error("Exception. Message: " + ex.Message + " Stack calls: " + ex.StackTrace);
                return BadRequest();
            }
        }

        [HttpDelete("DeleteStudent")]
        public IActionResult DeleteStudent(int studentId)
        {
            try
            {
                var result = _studentDataController.DeleteStudent(studentId);
                if (result == 0) return BadRequest(new { Message = "Student was not deleted" });
                return Ok(result);
            }
            catch (SqlException ex)
            {
                Log.Error("Problem with database. Message: " + ex.Message + " Stack calls: " + ex.StackTrace);
                return BadRequest("Problem with database");
            }
            catch (Exception ex)
            {
                Log.Error("Exception. Message: " + ex.Message + " Stack calls: " + ex.StackTrace);
                return BadRequest();
            }
        }
    }
}
