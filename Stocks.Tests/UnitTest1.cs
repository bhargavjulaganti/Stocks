using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using Xunit.Abstractions;

namespace Stocks.Tests;

public class UnitTest1 :  IClassFixture<WebApplicationFactory<Program>>, IDisposable
{
    private readonly WebApplicationFactory<Program> _factory;

    private readonly ITestOutputHelper _output;

    public UnitTest1(WebApplicationFactory<Program> factory,
        ITestOutputHelper output)
    {
        _factory = factory;
        _output = output;
    }

    [Fact]
    public async Task Test1()
    {
        var loanNumber = "1234";
        var client = _factory.CreateClient();

        var result = await client.GetAsync("/Stock");

        var response = await result.Content.ReadAsStringAsync();

        _output.WriteLine("**************");
        _output.WriteLine(response);
        _output.WriteLine("**************");

        Assert.True(result.IsSuccessStatusCode);
    }

    public void Dispose()
    {
        _output.WriteLine("Running dispose method");

    }   
}