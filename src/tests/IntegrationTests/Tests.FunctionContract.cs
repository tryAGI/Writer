namespace Writer.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void FunctionPositionalConstructorRetainsArgumentsThenName()
    {
        var function = new Function("{\"city\":\"Dubai\"}", "get_weather");
        function.Arguments.Should().Be("{\"city\":\"Dubai\"}");
        function.Name.Should().Be("get_weather");
        var roundtrip = Function.FromJson(function.ToJson())!;
        roundtrip.Name.Should().Be(function.Name);
        roundtrip.Arguments.Should().Be(function.Arguments);
    }
}
