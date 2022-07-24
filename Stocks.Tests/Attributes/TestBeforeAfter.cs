using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Stocks.Tests;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public class TestBeforeAfter : BeforeAfterTestAttribute
{

    public override void After(MethodInfo methodUnderTest)
    {
        Debug.WriteLine("After test");
        Debug.WriteLine(methodUnderTest.Name);

        var getbody = methodUnderTest.GetMethodBody().LocalVariables;

        foreach(var x in getbody)
        {
            var loan = x.LocalType;
            Debug.WriteLine(loan);
        }

        Debug.WriteLine(methodUnderTest.GetMethodBody());
    }
}