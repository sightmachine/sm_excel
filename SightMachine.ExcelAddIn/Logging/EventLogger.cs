using System.Diagnostics;

namespace ExcelAddIn.Logging
{
    public class EventLogger : LogBase
    {
        public override void Log(string message)
        {
            lock (LockObj)
            {
                var eventLog = new EventLog("")
                {
                    Source = "IDGEventLog"
                };

                eventLog.WriteEntry(message);
            }
        }
    }
}