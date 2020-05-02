using CryptoCurrencyAPI.Api.Models;
using CryptoCurrencyAPI.BusinessLayer.Models;
using CryptoCurrencyAPI.BusinessLayer.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CryptoCurrencyAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CryptocurrencyController : ControllerBase
    {
        private readonly ICryptocurrencyService _cryptocurrencyService;

        public CryptocurrencyController(ICryptocurrencyService cryptocurrencyService)
        {
            _cryptocurrencyService = cryptocurrencyService;
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetByNameAsync(string name)
        {
            var cryptocurrency = await _cryptocurrencyService.GetByNameAsync(name);
            if (cryptocurrency != null)
                return Ok(cryptocurrency);
            else
                return NotFound(new ErrorModel { StatusCode = 404, Message = "Not Found" });
        }

        [HttpPost]
        public async Task<IActionResult> InsertAsync([FromBody]CryptocurrencyModel cryptocurrency)
        {
            if (ModelState.IsValid)
            {
                await _cryptocurrencyService.InsertAsync(cryptocurrency);
                return Ok();
            }
            else
                return BadRequest();
        }
    }
}