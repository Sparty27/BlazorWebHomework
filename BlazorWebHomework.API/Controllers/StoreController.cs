using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MINT_WebAPI.Managers.StoreManaging;
using BlazorWebHomework.Models;

namespace MINT_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : Controller
    {
        private readonly IStoreManager _storeManager;

        public StoreController(IStoreManager storeManager)
        {
            _storeManager = storeManager;
        }

        [HttpGet("GetAllStores")]
        public IActionResult GetAllStores()
        {
            try
            {
                var stores = _storeManager.GetAllStores();
                return Ok(stores);
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

        [HttpGet("GetStoreById")]
        public IActionResult GetStoreById(int id)
        {
            try
            {
                var store = _storeManager.GetStoreById(id);
                return Ok(store);
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

        [HttpGet("GetStoreByName")]
        public IActionResult GetStoreByName(string name)
        {
            try
            {
                var store = _storeManager.GetStoreByName(name);
                return Ok(store);
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

        [HttpPost("CreateStore")]
        public IActionResult CreateStore(Store store)
        {
            try
            {
                var result = _storeManager.CreateStore(store);
                if (result == 0) return BadRequest(new { Message = "Store was not created" });
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

        [HttpPut("UpdateStore")]
        public IActionResult UpdateStore(Store store)
        {
            try
            {
                var result = _storeManager.UpdateStore(store);
                if (result == 0) return BadRequest(new { Message = "Store was not updated" });
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

        [HttpDelete("DeleteStoreById")]
        public IActionResult DeleteStoreById(int id)
        {
            try
            {
                var result = _storeManager.DeleteStoreById(id);
                if (result == 0) return BadRequest(new { Message = "Store was not deleted" });
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
