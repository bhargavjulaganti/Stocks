using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Stocks.Tests;

[CollectionDefinition("FunctionalTest collection")]
public class FunctionalTestCollection : ICollectionFixture<FunctionalTestFixture>
{
    // This class has no code, and is never created. Its purpose is simply
    // to be the place to apply [CollectionDefinition] and all the
    // ICollectionFixture<> interfaces.
}