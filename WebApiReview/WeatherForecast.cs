namespace WebApiReview
{
    public class WeatherForecast
    {   
        public DateOnly Date { get; set; }

        //���ū�
        public int TemperatureC { get; set; }

        //�ؤ�ū�
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        //�i��null������
        public string? Summary { get; set; }
    }
}
