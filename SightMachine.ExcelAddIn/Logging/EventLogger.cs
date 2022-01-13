using System;
using System.Diagnostics;

namespace ExcelAddIn.Logging
{
    public class EventLogger : LogBase
    {
        public override void Log(string message)
        {
            try
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
            catch (System.Exception e)
            {
                // suppress
            }
        }
    }
}