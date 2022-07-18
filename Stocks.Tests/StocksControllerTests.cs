using System.Threading.Tasks;
using RA;
using Xunit;

namespace Stocks.Tests;

public class StocksControllerTests
{
    // [Fact]
    public async Task GetStock()
    {
        //Create a new test suite
        new RestAssured()
        .Given()
            .Name("JsonIP Test Suite")
            .Header("Content-Type", "application/json")
            .Header("Accept-Encoding", "gzip,deflate")
        .When()
            //url
            .Get("http://localhost:5055/Stock")
        .Then()
            .TestStatus("test status", x => x == 200)
            .TestBody("test a", x => x.stockName == "SOFI")
            .AssertAll();
            // .Assert("test a")
            // .Assert("test status");
    }
}