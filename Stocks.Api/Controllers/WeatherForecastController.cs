using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Stocks.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private HttpClient _backendHttpClient;
    
    public WeatherForecastController()
    {
        _backendHttpClient = new HttpClient();
    }
    
    [HttpGet]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        var result = await _backendHttpClient.GetAsync("http://localhost:58116/weatherforecastbackend");
        return JsonConvert.DeserializeObject<IEnumerable<WeatherForecast>>(await result.Content.ReadAsStringAsync());
    }
}
