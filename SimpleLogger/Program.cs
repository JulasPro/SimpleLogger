using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            string entryMessage = "Simple Logger - New log entry";
            
            List<ILogger> loggers = new List<ILogger>
            {
                new FileLogger(),
                new ConsoleLogger(),
                new EventLogLogger(),
            };

            loggers.ForEach(logger => logger.WriteLogEntry(entryMessage));

            Console.ReadKey();
        }
    }
}
