using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RunWalkManager.Web.Services.Implementations;
using RunWalkManager.Web.Services.Interfaces;

namespace RunWalkManager.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IWeatherForecastService _service;
        private readonly ILogger<WeatherForecastController> _logger;
        /*
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _service = new WeatherForecastService();
        }*/

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            IWeatherForecastService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return _service.Get();
        }
    }
}
