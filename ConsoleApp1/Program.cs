using ConsoleApp.Enum;
using Factory;

// assume tomorrow is a sunny day
int tomorrowForecast = (int)WeatherEnum.Sunny;
WeatherFactory weatherGenerator = new WeatherFactory();

// generate weather
WeatherEnum forecast = weatherGenerator.GenerateWeather(tomorrowForecast);

if (forecast == WeatherEnum.Sunny)
{
    Console.WriteLine("Let's play badmindton!");
}
else if(forecast == WeatherEnum.Cloudy)
{
    Console.WriteLine("Remember to bring the umbella.");
}
else
{
    Console.WriteLine("See you Next Appointment!");
}


