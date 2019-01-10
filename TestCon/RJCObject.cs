namespace TestCon
{
    public class RJCObject<T> 
    {
        private ILogger _myLog;
        public RJCObject(ILogger log)
        {
            _myLog = log;
        }

        public void ShowDetails()
        {
            _myLog.Write($"this is of type {typeof(T).ToString()}");
        }
    }
}