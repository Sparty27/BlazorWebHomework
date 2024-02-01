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
                Log.Error("Problem with database. Message: " + ex.Message + " Stack calls: " + ex.StackTrace);
                return BadRequest("Problem with database");
            }
            catch (Exception ex)
            {
                Log.Error("Exception. Message: " + ex.Message + " Stack calls: " + ex.StackTrace);
                return BadRequest();
            }
        }

        [HttpGet("GetGroups")]
        public IActionResult GetGroups(int Skip, int Take, string? SearchText = null)
        {
            try
            {
                var groups = _groupDataController.GetGroups(Skip, Take, SearchText);
                return Ok(groups);
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
        [HttpGet("GetGroupsByFacultyId")]
        public IActionResult GetGroupsByFacultyId(int facultyId)
        {
            try
            {
                var groups = _groupDataController.GetGroupsByFacultyId(facultyId);
                return Ok(groups);
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
                Log.Error("Problem with database. Message: " + ex.Message + " Stack calls: " + ex.StackTrace);
                return BadRequest("Problem with database");
            }
            catch (Exception ex)
            {
                Log.Error("Exception. Message: " + ex.Message + " Stack calls: " + ex.StackTrace);
                return BadRequest();
            }
        }

        [HttpGet("GetCount")]
        public IActionResult GetCount(string? searchText = null)
        {
            try
            {
                var count = _groupDataController.GetCount(searchText);
                return Ok(count);
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
                Log.Error("Problem with database. Message: " + ex.Message + " Stack calls: " + ex.StackTrace);
                return BadRequest("Problem with database");
            }
            catch (Exception ex)
            {
                Log.Error("Exception. Message: " + ex.Message + " Stack calls: " + ex.StackTrace);
                return BadRequest();
            }
        }

        [HttpPut("UpdateGroup")]
        public IActionResult UpdateGroup(Group group)
        {
            try
            {
                var result = _groupDataController.UpdateGroup(group);
                if (result == 0) return BadRequest(new { Message = "Group was not updated" });
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
