using System.Diagnostics;
using System.IO;

namespace SimpleLogger
{
    /// <summary>
    /// Class implementing writing log message to file.
    /// </summary>
    public class FileLogger : ILogger
    {
        private const string FILE_NAME = "fileLogger.txt";

        /// <summary>
        /// Method to write message as log entry
        /// </summary>
        /// <param name="message">Custom message to write in new log entry.</param>
        public void WriteLogEntry(string message)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(FILE_NAME))
                {
                    sw.WriteLine(message);
                }
            }
            catch
            {
                Debug.WriteLine($"Unable to open {FILE_NAME} due file is in use");
            }
        }
    }
}
