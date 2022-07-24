
using System;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

public class FunctionalTestFixture : IClassFixture<WebApplicationFactory<Program>>, IDisposable
{
    public FunctionalTestFixture()
    {
    }

    public void Dispose()
    {
        // ... clean up test data from the database ...
    }

    // public string Db { get; private set; }

    public string passedConstructorValue { get; set;}

    public HttpClient FunctionalTestClient ;

    public string FixtureName = "FunctionalTest";
}