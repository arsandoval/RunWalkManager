using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunWalkManager.Web.Services.Interfaces
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> Get();
    }
}
