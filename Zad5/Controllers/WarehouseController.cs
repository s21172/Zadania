using Microsoft.AspNetCore.Mvc;
using Zad5.DTO;
using Zad5.Services;

namespace Zad5.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class WarehouseController : Controller
    {
        private readonly IDbService _dbService;

        public WarehouseController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] AddProductDTO productDto)
        {
            AddProductResult result = await _dbService.PostProduct(productDto);
            return StatusCode((int)result.StatusCode, result.Message);

        }
    }
}