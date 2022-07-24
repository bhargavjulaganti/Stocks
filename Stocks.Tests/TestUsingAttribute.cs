using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Stocks.Tests;

public class TestUsingAttribute 
{
    private readonly ITestOutputHelper _output;

    public TestUsingAttribute(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    [TestBeforeAfter]
    public async Task Test1()
    {
        var loanNumber = "1234";

    }

    public void Dispose()
    {
        _output.WriteLine("Running dispose method");
    }   
}