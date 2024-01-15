using BlazorWebHomeworkAPI.DataControllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using BlazorWebHomework.Models;


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
        public IActionResult GetAllStudents()
        {
            try
            {
                var students = _studentDataController.GetAllStudents();
                return Ok(students);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest("Problem with database");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                Console.WriteLine(ex.Message);
                return BadRequest("Problem with database");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                Console.WriteLine(ex.Message);
                return BadRequest("Problem with database");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                Console.WriteLine(ex.Message);
                return BadRequest("Problem with database");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }

        //[HttpGet("GetFaculties")]
        //public IActionResult GetFaculties()
        //{
        //    try
        //    {
        //        var faculties = _facultyDataController.GetFaculties();
        //        return Ok(faculties);
        //    }
        //    catch (SqlException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return BadRequest("Problem with database");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return BadRequest();
        //    }
        //}

        //[HttpGet("GetFacultyById")]
        //public IActionResult GetFacultyById(int id)
        //{
        //    try
        //    {
        //        var faculty = _facultyDataController.GetFacultyById(id);

        //        if (faculty == null) return BadRequest("Error, object was not found");
        //        return Ok(faculty);
        //    }
        //    catch (SqlException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return BadRequest("Problem with database");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return BadRequest();
        //    }
        //}

        //[HttpPost("CreateFaculty")]
        //public IActionResult CreateStore(Faculty faculty)
        //{
        //    try
        //    {
        //        var result = _facultyDataController.CreateFaculty(faculty);
        //        if (result == 0) return BadRequest(new { Message = "Faculty was not created" });
        //        return Ok(result);
        //    }
        //    catch (SqlException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return BadRequest("Problem with database");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return BadRequest();
        //    }
        //}

        //[HttpPut("UpdateFaculty")]
        //public IActionResult UpdateFaculty(Faculty faculty)
        //{
        //    try
        //    {
        //        var result = _facultyDataController.UpdateFaculty(faculty);
        //        if (result == 0) return BadRequest(new { Message = "Faculty was not updated" });
        //        return Ok(result);
        //    }
        //    catch (SqlException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return BadRequest("Problem with database");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return BadRequest();
        //    }
        //}

        //[HttpDelete("DeleteFaculty")]
        //public IActionResult DeleteFaculty(int facultyId)
        //{
        //    try
        //    {
        //        var result = _facultyDataController.DeleteFaculty(facultyId);
        //        if (result == 0) return BadRequest(new { Message = "Faculty was not deleted" });
        //        return Ok(result);
        //    }
        //    catch (SqlException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return BadRequest("Problem with database");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return BadRequest();
        //    }
        //}
    }
}
