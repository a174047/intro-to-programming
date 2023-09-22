using Alba;

namespace BusinessClockApi.IntegrationTests.Clock;
public class GettingTheClock
{
    [Fact]
    public async Task GivesMeA200()
    {
        var host = await AlbaHost.For<Program>();

        await host.Scenario(api =>
        {
            api.Get.Url("/clock");
            api.StatusCodeShouldBeOk();
        });
    }

    [Fact]
    public async Task DuringOpenHours()
    {
        // Given
        var expectedResponse = new ClockResponse(true, null);
        var host = await AlbaHost.For<Program>();

        // When
        var reponse = await host.Scenario(api =>
        {
            api.Get.Url("/clock");

        });

        var result = reponse.ReadAsJson<ClockResponse>();
        Assert.Equal(expectedResponse, result);
    }

    [Fact]
    public async Task AfternHours()
    {
        // Given
        //var expectedResponse = new ClockResponse(false, null);
        var host = await AlbaHost.For<Program>();

        // When
        var reponse = await host.Scenario(api =>
        {
            api.Get.Url("/clock");

        });

        var result = reponse.ReadAsJson<ClockResponse>();

        Assert.False(result.open);
        Assert.NotNull(result.opensNext);
        //Assert.Equal(expectedResponse, result);
    }
}
