namespace WebApiReview
{
    public class WeatherForecast
    {   
        public DateOnly Date { get; set; }

        //攝氏溫度
        public int TemperatureC { get; set; }

        //華氏溫度
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        //可為null的結論
        public string? Summary { get; set; }
    }
}
