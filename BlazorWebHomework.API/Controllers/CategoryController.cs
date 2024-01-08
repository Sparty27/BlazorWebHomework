using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MINT_WebAPI.Managers.CategoryManaging;
using BlazorWebHomework.Models;

namespace MINT_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryManager _categoryManager;

        public CategoryController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet("GetCategories")]
        public IActionResult GetAllCategories()
        {
            try
            {
                var categories = _categoryManager.GetAllCategories();
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

        [HttpGet("GetCategoryById")]
        public IActionResult GetCategoryById(int id)
        {
            try
            {
                var category = _categoryManager.GetCategoryById(id);
                if (category == null) return BadRequest(new { Message = "Category was not found" });
                return Ok(category);
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

        [HttpGet("GetCategoryByName")]
        public IActionResult GetCategoryByName(string name)
        {
            try
            {
                var category = _categoryManager.GetCategoryByName(name);
                if (category == null) return BadRequest(new { Message = "Category was not found" });
                return Ok(category);
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

        [HttpPost("CreateCategory")]
        public IActionResult CreateCategory(Category category)
        {
            try
            {
                var result = _categoryManager.CreateCategory(category);
                if (result == 0) return BadRequest(new { Message = "Category was not created" });
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

        [HttpPut("UpdateCategory")]
        public IActionResult UpdateCategory(Category category)
        {
            try
            {
                var result = _categoryManager.UpdateCategory(category);
                if (result == 0) return BadRequest(new { Message = "Category was not updated" });
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

        [HttpDelete("DeleteCategoryById")]
        public IActionResult UpdateCategory(int id)
        {
            try
            {
                var result = _categoryManager.DeleteCategoryById(id);
                if (result == 0) return BadRequest(new { Message = "Category was not deleted" });
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
