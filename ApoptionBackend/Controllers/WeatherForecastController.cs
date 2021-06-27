using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FullStackDevExercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "gunjan","monita"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<String> Get()
        {
           return Summaries;
        }
    [HttpGet]
    [Route("test")]
    public String GetKey()
    {
      if(Request.Headers.ContainsKey("Shared-Api-Token"))
      {
        return Request.Headers["Shared-Api-Token"].ToString();
      }
      else
      {
        return "not found";
      }
    }

    }
}
