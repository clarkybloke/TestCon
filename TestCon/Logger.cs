namespace TestCon
{
    public class Logger : ILogger
    {
        private readonly ILogger _log;

        public Logger(ILogger log)
        {
            _log = log;
        }

        public void Write(string message)
        {
            _log.Write(message);
        }
    }
}