using Microsoft.AspNetCore.Mvc;
using Stocks.Api.DataLayer;

namespace Stocks.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class StockController : ControllerBase
{
    private readonly IStockPositionsDataLayer _stockPositionsDataLayer;
    public StockController(IStockPositionsDataLayer stockPositionsDataLayer)
    {
        _stockPositionsDataLayer = stockPositionsDataLayer;
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

    [HttpPost(Name = "PostStock")]
    public async Task Post([FromBody] string stockName)
    {
        await _stockPositionsDataLayer.CreateStockPosition(stockName);
    }
}
