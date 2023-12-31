using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebApiReview.Controllers
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

        [HttpGet(Name = "GetWeatherForecast")]
        public string GetWeatherForecast()
        {
            try
            {
                IEnumerable<int> randomRange = Enumerable.Range(1, 5);
                IEnumerable<WeatherForecast> weatherForecast = randomRange.Select(index => new WeatherForecast
                {
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                });

                string response = JsonConvert.SerializeObject(weatherForecast);
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"GetWeatherForecast Error_{DateTime.Now}");

                //If error happens, return error message
                return new string("somethings break, please wait and contact your IT Developer");
            }
        }
    }
}
