using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using HyperGenesis;

namespace HyperGenesis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Basic()
        {
            return "Welcome to the API!";
        }

        [HttpGet("/GenRoom")]
        public string Get(){
            // Critter example = new Critter();
            Level example = new Level();
            Room room1 = new Room();
            room1.randomize();
            string result = JsonConvert.SerializeObject(room1.export()); // This serializes an object into a JSON string to be transferred
            return result;
        }
    }
}
      