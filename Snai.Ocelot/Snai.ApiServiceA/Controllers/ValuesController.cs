using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Snai.ApiServiceA.Controllers
{
    [Route("apiservice/[controller]")]
    public class ValuesController : Controller
    {
        public IConfiguration Configuration { get; }

        public ValuesController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            return HttpContext.Request.Host.Port + " " + Configuration["AppName"] + " " + DateTime.Now.ToString();
        }

        [HttpGet("/health")]
        public IActionResult Heathle()
        {
            return Ok();
        }
    }
}
