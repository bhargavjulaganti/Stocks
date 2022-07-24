using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

[Collection("FunctionalTest collection")]
public class FunctionalTest
{
    FunctionalTestFixture _fixture;
    ITestOutputHelper testOutputHelper;

    public FunctionalTest(FunctionalTestFixture fixture,
    ITestOutputHelper testOutputHelper)
    {
        _fixture = fixture;
        this.testOutputHelper = testOutputHelper;
    }

    [Fact]
    public async Task Test1()
    {
        this.testOutputHelper.WriteLine("*****************************");
        this.testOutputHelper.WriteLine(_fixture.FixtureName);
        this.testOutputHelper.WriteLine("*****************************");

        var result = await _fixture.FunctionalTestClient.GetAsync("/Stock");
        var response = await result.Content.ReadAsStringAsync();

        this.testOutputHelper.WriteLine(response);
    }
}