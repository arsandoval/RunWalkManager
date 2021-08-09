using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunWalkManager.Web.Repository.Interfaces
{
    public interface IWeatherForecastRepository
    {
        IEnumerable<WeatherForecast> Get();
    }
}
