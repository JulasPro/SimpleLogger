namespace SimpleLogger
{
    /// <summary>
    /// Public interface for every logger
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Method to write message as log entry
        /// </summary>
        /// <param name="message">Custom message to write in new log entry.</param>
        public void WriteLogEntry(string message);
    }
}
