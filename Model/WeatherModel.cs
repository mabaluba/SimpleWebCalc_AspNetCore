using System.Collections.Generic;

namespace asp_less3_ex1_calc.Model
{
    public sealed class WeatherModel
    {
        public Main main { get; set; }
        public string name { get; set; }
        public List<Weather> weather { get; set; }
    }
    public sealed class Main
    {
        public double temp { get; set; }
    }
    public sealed class Weather
    {
        public string description { get; set; }
    }
}
