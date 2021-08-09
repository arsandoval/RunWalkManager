using RunWalkManager.Web.Repository.Interfaces;
using RunWalkManager.Web.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunWalkManager.Web.Services.Implementations
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private IWeatherForecastRepository _repo;
        public WeatherForecastService(IWeatherForecastRepository repo)
        {
            _repo = repo;
        }
        public IEnumerable<WeatherForecast> Get()
        {
            return _repo.Get();
        }
    }
}
