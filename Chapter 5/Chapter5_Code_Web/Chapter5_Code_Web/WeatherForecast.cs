namespace Chapter5_Code_Web
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public float Calculate1()
        {
            var minValue = 25;
            return Calculate(minValue);
        }
        public float Calculate2()
        {
            var minValue = 88;

            return Calculate(minValue);
        }

        public float Calculate3()
        {
            var minValue = 56;
            return (float)((minValue + 126) * (Math.PI / minValue));
        }

        public float Calculate(int value)
        {
            return (float)((value + 126) * (Math.PI / value));
        }
    }
}