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
    public class CoronaController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CoronaController> logger;

        public CoronaController(ILogger<CoronaController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IEnumerable<CoronaData> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new CoronaData
            {   
                ProvinceState = Summaries[rng.Next(Summaries.Length)],
                CountryRegion = Summaries[rng.Next(Summaries.Length)],
                Confirmed = rng.Next(-20, 55),
                Death = rng.Next(-20, 55),
                Latitude = 30.9756,
                Longtitude = 112.2707,
                Summary = Summaries[rng.Next(Summaries.Length)]

            })
            .ToArray();
        }
    }
}
