using BlazorWebHomework.API.DataControllers;
using BlazorWebHomeworkAPI.DataControllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace BlazorWebHomework.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : Controller
    {
        private readonly GroupDataController _groupDataController;

        public GroupController(IConfiguration configuration)
        {
            _groupDataController = new GroupDataController(configuration);
        }

        [HttpGet("GetAllGroups")]
        public IActionResult GetAllGroups()
        {
            try
            {
                var groups = _groupDataController.GetAllGroups();
                return Ok(groups);
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

        [HttpGet("GetGroups")]
        public IActionResult GetGroups(int Skip, int Take)
        {
            try
            {
                var groups = _groupDataController.GetGroups(Skip, Take);
                return Ok(groups);
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

        [HttpGet("GetCount")]
        public IActionResult GetCount()
        {
            try
            {
                var count = _groupDataController.GetCount();
                return Ok(count);
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
