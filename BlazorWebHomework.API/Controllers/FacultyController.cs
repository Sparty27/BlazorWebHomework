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

        [HttpGet("GetFaculties")]
        public IActionResult GetFaculties()
        {
            try
            {
                var categories = _facultyDataController.GetFaculties();
                return Ok(categories);
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
                Console.WriteLine(ex.Message);
                return BadRequest("Problem with database");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }
    }
}
