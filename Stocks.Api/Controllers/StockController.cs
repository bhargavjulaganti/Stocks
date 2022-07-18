using Microsoft.AspNetCore.Mvc;

namespace Stocks.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class StockController : ControllerBase
{
    public StockController()
    {
    }

    [HttpGet(Name = "GetStock")]
    public Stocks Get()
    {
        var stockObject = new Stocks
        {
            StockName = "SOFI",
        };
        return stockObject;
    }
   
}
