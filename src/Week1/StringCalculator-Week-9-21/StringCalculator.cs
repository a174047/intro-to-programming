namespace StringCalculator;

public class StringCalculator
{
    private readonly ILogger _logger;
    private readonly IWebService _opsAPI;

    public StringCalculator(ILogger logger, IWebService opsAPI)
    {
        _logger = logger;
        _opsAPI = opsAPI;
    }

    public int Add(string numbers)
    {
        int result;
        if (numbers == "")
        {
            result = 0;
        }
        else
        {
            result = numbers.Split(',').Select(int.Parse).Sum();
        }
        try
        {
            _logger.Write(result.ToString());
        }
        catch (LoggerException)
        {
            _opsAPI.NotifyOfLoggerFailure("Logger Went Boom");
        }
        return result;
    }


}

public interface ILogger
{
    void Write(string message);
}

public interface IWebService

{
    void NotifyOfLoggerFailure(string message);
}

public class LoggerException : ApplicationException
{

}
