using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace asp_less3_ex1_calc.Model
{
    public class WeatherService
    {
        public async Task<WeatherModel> GetWeatherAsync()
        {
            var cityId = "5392967";
            var key = "256e063b47a3e8233cad56edfea9a75b";
            var url = $"http://api.openweathermap.org/data/2.5/weather?id={cityId}&units=metric&lang=en&appid={key}";
            string result;
            HttpClient client = new();
            using (var response = await client.GetAsync(url))
            {
                response.EnsureSuccessStatusCode();
                result = await response.Content.ReadAsStringAsync();
            }
            return JsonSerializer.Deserialize<WeatherModel>(result);
        }
    }
}
