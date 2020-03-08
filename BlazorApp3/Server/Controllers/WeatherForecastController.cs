using BlazorApp3.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlazorApp3.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            this.logger = logger;
        }



        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 1).Select(index => new WeatherForecast
            {
                ProvinceState = "Hubei",
                CountryRegion = "Mainland China",
                Confirmed = 67666,
                Death = 2959,
                Latitude = 30.9756,
                Longtitude = 112.2707,
                Summary = Summaries[rng.Next(Summaries.Length)]

            })
            .ToArray();
        }
    }
}
