using NSubstitute;

namespace StringCalculator;
public class StringCalculatorInteractionTests
{
    /*private readonly StringCalculator _calculator;

    public StringCalculatorInteractionTests()
    {
        _calculator = new StringCalculator();
    }*/

    [Theory]
    [InlineData("9", "9")]
    public void ResultsAreWrittenToALogger(string numbers, string logged)
    {
        var fakeLogger = Substitute.For<ILogger>();
        var fakeIWebService = Substitute.For<IWebService>();
        var calculator = new StringCalculator(fakeLogger, fakeIWebService);
        calculator.Add(numbers);


        // THEN??? What am I going to assert on?
        fakeLogger.Received(1).Write(logged);
        fakeIWebService.DidNotReceive().NotifyOfLoggerFailure(Arg.Any<string>());
    }

    [Fact]
    public void WebServiceCalledIfLoggerThrows()
    {
        var fakeLogger = Substitute.For<ILogger>();
        var fakeWebService = Substitute.For<IWebService>();
        fakeLogger.When(c => c.Write(Arg.Any<string>())).Throw<LoggerException>();
        var calculator = new StringCalculator(fakeLogger, fakeWebService);

        calculator.Add("123");

        fakeWebService.Received(1).NotifyOfLoggerFailure("Logger Went Boom");
    }
}
