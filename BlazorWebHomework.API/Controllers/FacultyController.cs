using BlazorWebHomeworkAPI.DataControllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using BlazorWebHomework.Models;


namespace BlazorWebHomeworkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacultyController : Controller
    {
        private readonly FacultyDataController _facultyDataController;

        public FacultyController(IConfiguration configuration)
        {
            _facultyDataController = new FacultyDataController(configuration);
        }

        [HttpGet("GetAllFaculties")]
        public IActionResult GetAllFaculties(string? searchText = null)
        {
            try
            {
                var faculties = _facultyDataController.GetAllFaculties(searchText);
                return Ok(faculties);
            }
            catch (SqlException ex)
            {
                Log.Error("Problem with database. Message: " + ex.Message + " Stack calls: " + ex.StackTrace);
                return BadRequest("Problem with database");
            }
            catch (Exception ex)
            {
                Log.Error("Problem with database. Message: " + ex.Message + " Stack calls: " + ex.StackTrace);
                return BadRequest();
            }
        }

        [HttpGet("GetFaculties")]
        public IActionResult GetFaculties()
        {
            try
            {
                var faculties = _facultyDataController.GetFaculties();
                return Ok(faculties);
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

        [HttpGet("GetFacultyById")]
        public IActionResult GetFacultyById(int id)
        {
            try
            {
                var faculty = _facultyDataController.GetFacultyById(id);

                if (faculty == null) return BadRequest("Error, object was not found");
                return Ok(faculty);
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

        [HttpPost("CreateFaculty")]
        public IActionResult CreateStore(Faculty faculty)
        {
            try
            {
                var result = _facultyDataController.CreateFaculty(faculty);
                if (result == 0) return BadRequest(new { Message = "Faculty was not created" });
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

        [HttpPut("UpdateFaculty")]
        public IActionResult UpdateFaculty(Faculty faculty)
        {
            try
            {
                var result = _facultyDataController.UpdateFaculty(faculty);
                if (result == 0) return BadRequest(new { Message = "Faculty was not updated" });
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

        [HttpDelete("DeleteFaculty")]
        public IActionResult DeleteFaculty(int facultyId)
        {
            try
            {
                var result = _facultyDataController.DeleteFaculty(facultyId);
                if (result == 0) return BadRequest(new { Message = "Faculty was not deleted" });
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
