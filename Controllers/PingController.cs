using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicGymGateway.Controllers
{
    public class PingController : Controller
    {
        [HttpGet]
        [Route("/ping")]
        public IActionResult Ping()
        {
            return Ok("Hello world!");
        }
    }
}
