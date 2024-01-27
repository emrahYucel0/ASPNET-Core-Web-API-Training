using Microsoft.AspNetCore.Mvc;
using WebAPIExample.Models;
using System.Reflection.Metadata.Ecma335;

namespace WebAPIExample.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController:ControllerBase
    {
        [HttpGet]
        public IActionResult GetMessage()
        {
            var result = new ResponseModel()
            {
                HTTPStatus = 200,
                Message = "Hello ASP.NET Core Web API"

            };
            return Ok(result);
        }
    }
}
