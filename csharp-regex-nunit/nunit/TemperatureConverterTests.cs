using NUnit.Framework;

public class TemperatureConverter
{
    public double CelsiusToFahrenheit(double c) => (c * 9 / 5) + 32;
    public double FahrenheitToCelsius(double f) => (f - 32) * 5 / 9;
}

[TestFixture]
public class TemperatureConverterTests
{
    [Test]
    public void Conversion_Test()
    {
        TemperatureConverter tc = new TemperatureConverter();
        Assert.AreEqual(32, tc.CelsiusToFahrenheit(0));
        Assert.AreEqual(0, tc.FahrenheitToCelsius(32));
    }
}
