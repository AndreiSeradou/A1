using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UnauthorizedDeliveriesTask3WebApi.Interfaces.Services;
using UnauthorizedDeliveriesTask3WebApi.Models;

namespace UnauthorizedDeliveriesTask3WebApi.Controllers
{

    [ApiController]
        [Route("[controller]")]

        public class CsvController : ControllerBase
        {

            private ICsvServices _csvServices;

            public CsvController(ICsvServices  csvServices)
            {
                _csvServices = csvServices;
            }

        [HttpGet("getData")]
        public async Task<IActionResult> GetByDateTimeAsync(Request model)
        {
            var response = await _csvServices.GetByDateTimeAsync(model).ConfigureAwait(false);

            if (response == null)
                return BadRequest(new { message = "Error" });

            return Ok(response);
        }


        [HttpGet("getDataBool")]
        public async Task<IActionResult> GetByDateTimeAndAuthorizedAsync(Request model)
        {
            var response = await _csvServices.GetByDateTimeAndAuthorizedAsync(model).ConfigureAwait(false);

            if (response == null)
                return BadRequest(new { message = "Error" });

            return Ok(response);
        }
    }

}
