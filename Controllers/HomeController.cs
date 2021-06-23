using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WindowAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IActionResult GetValuesAsync()
        {
            var newobj = new
            {
                data = "api triggerd"
            };
            return Ok(newobj);
        }

        [HttpGet("noauth")]
        public IActionResult GetWithoutLogin()
        {
            var newobj = new
            {
                data = "without auth triggerd"
            };
            return Ok(newobj);
        }
    }
}
