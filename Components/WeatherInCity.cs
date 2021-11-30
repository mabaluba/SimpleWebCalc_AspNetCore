using asp_less3_ex1_calc.Model;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace asp_less3_ex1_calc.Components
{
    public class WeatherInCity: ViewComponent
    {
        private readonly WeatherService _service;
        public WeatherInCity(WeatherService service)
        {
            _service = service;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            WeatherModel weather = await _service.GetWeatherAsync();
            return View(weather);
        }
    }
}
