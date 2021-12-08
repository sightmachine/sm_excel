namespace ExcelAddIn.Logging
{
    public abstract class LogBase
    {
        protected readonly object LockObj = new object();
        public abstract void Log(string message);
    }
}