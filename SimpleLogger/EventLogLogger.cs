using System.Diagnostics;

namespace SimpleLogger
{
    /// <summary>
    /// Class implementing writing log message to Windows Event Log.
    /// </summary>
    public class EventLogLogger : ILogger
    {
        /// <summary>
        /// Method to write message as log entry
        /// </summary>
        /// <param name="message">Custom message to write in new log entry.</param>
        public void WriteLogEntry(string message)
        {
            using (var eventLog = new EventLog("Application"))
            {
                eventLog.Source = "EventLogLogger";
                eventLog.WriteEntry(message, EventLogEntryType.Information, 101);
            }
        }
    }
}
