using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Hotels.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("1.1")]
    [ApiVersion("2.0")]
    public class TestController : ControllerBase
    {
        [HttpGet(Name = nameof(GetCustomers))]
        public IActionResult GetCustomers()
        {
            List<string> customers = new List<string>()
            {
                "ofsonmez",
                "ike"
            };

            return Ok(customers);
        }
        
        [ApiVersion("1.0", Deprecated = true)]
        [MapToApiVersion("1.1")]
        [HttpGet(Name = nameof(GetCustomerV2))]
        public IActionResult GetCustomerV2()
        {
            List<string> customers = new List<string>()
            {
                "sönmez",
                "boranay"
            };

            return Ok(customers);
        }
    }
}