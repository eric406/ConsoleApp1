using Microsoft.AspNetCore.Mvc;
using System.Linq;

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
        public IEnumerable<WeatherForecast> GetWeatherForecast()
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

                return weatherForecast.ToArray();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"GetWeatherForecast Error_{DateTime.Now}");

                //If error happens, return empty Enumerable
                return Enumerable.Empty<WeatherForecast>();
            }
        }
    }
}
