using System;

namespace SimpleLogger
{
    /// <summary>
    /// Class implementing writing log message to application console.
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        /// <summary>
        /// Method to write message as log entry
        /// </summary>
        /// <param name="message">Custom message to write in new log entry.</param>
        public void WriteLogEntry(string message)
        {
            Console.WriteLine(message);
        }
    }
}
