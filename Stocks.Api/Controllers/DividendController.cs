using Microsoft.AspNetCore.Mvc;
using Stocks.Api.DataLayer;

namespace Stocks.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class DividendRecordController : ControllerBase
{
    private readonly IDividendDataLayer _dividendDataLayer;
    
    public DividendRecordController(IDividendDataLayer dividendDataLayer)
    {
        _dividendDataLayer = dividendDataLayer;
    }

    [HttpGet("ByStock")]
    [ProducesResponseType(typeof(IEnumerable<Models.Entity.DividendRecords>), StatusCodes.Status200OK)]
    public IActionResult  ByStock([FromQuery] string stockName)
    {
        var result =  _dividendDataLayer.RetrieveDividends(stockName);
        
        return Ok(result);
    }
    
    [HttpGet( "All")]
    [ProducesResponseType(typeof(IEnumerable<Models.Entity.DividendRecords>), StatusCodes.Status200OK)]
    public IActionResult  All()
    {
        var result = _dividendDataLayer.RetrieveAllDividendRecords();
        
        return Ok(result);
    }
}
