using BlazorWebHomework.API.DataControllers;
using BlazorWebHomework.Models;
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

        [HttpGet("GetGroupByName")]
        public IActionResult GetGroupByName(string groupName = "groupName")
        {
            try
            {
                var group = _groupDataController.GetGroupByName(groupName);
                Console.WriteLine("Controller, Group: " + group);
                Console.WriteLine("Controller,Is Group NULL: " + (group is null));
                return Ok(group);
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

        [HttpPost("CreateGroup")]
        public IActionResult CreateGroup(Group group)
        {
            try
            {
                var result = _groupDataController.CreateGroup(group);
                if (result == 0) return BadRequest(new { Message = "Group was not created" });
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

        [HttpDelete("DeleteGroup")]
        public IActionResult DeleteGroup(int groupId)
        {
            try
            {
                var result = _groupDataController.DeleteGroup(groupId);
                if (result == 0) return BadRequest(new { Message = "Group was not deleted" });
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
