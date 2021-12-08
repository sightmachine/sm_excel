namespace ExcelAddIn.Logging
{
    public static class LogHelper
    {
        private static LogBase _logger;
        public static void Log( string message)
        {
            _logger = new EventLogger();
            _logger.Log(message);
        }
    }
}