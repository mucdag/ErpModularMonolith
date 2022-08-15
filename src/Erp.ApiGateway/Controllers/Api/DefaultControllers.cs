using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Erp.ApiGateway.Controllers.Api
{
    [Route("api/")]
    [ApiController]
    public class DefaultControllers : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Console.WriteLine("--> Getting....");
            return Ok("Api Run");
        }
    }
}