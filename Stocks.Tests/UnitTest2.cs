using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Stocks.Tests;

public class UnitTest2 
{

    public UnitTest2()
    {
  
    }

    [Fact]
    [TestBeforeAfter]
    public async Task Test1()
    {
        var loanNumber = "1234";
    } 
}