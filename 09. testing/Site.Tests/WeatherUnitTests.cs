namespace Site.Tests;

public class WeatherUnitTests
{
    [Fact]
    public void Gets5Forecasts()
    {
        // arrange
        var logger = new Mock<ILogger<WeatherForecastController>>();
        WeatherForecastController controller = new WeatherForecastController(logger.Object); // TODO: use AutoMocker

        // act
        IEnumerable<WeatherForecast> weatherForecasts = controller.Get();

        // assert
        using (new AssertionScope())
        {
            weatherForecasts.Should().NotBeNull();
            weatherForecasts.Should().HaveCount(5);
        }
    }

}
