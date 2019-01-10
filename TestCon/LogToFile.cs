using System;
using System.IO;

namespace TestCon
{
    public class LogToFile : ILogger
    {
        private string _logfile = "testlog.txt";
        public void Write(string message)
        {
            File.AppendAllText(_logfile,message + Environment.NewLine);
        }
    }
}