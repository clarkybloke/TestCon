using System;

namespace TestCon
{
    public class LogToScreen : ILogger
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}