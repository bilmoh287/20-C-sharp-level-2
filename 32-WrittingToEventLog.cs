using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lever_2
{
    public class _32_WrittingToEventLog
    {
        public class Program
        {
            public static void Main()
            {
                // Specify the source name for the event log
                string sourceName = "MyApp";


                // Create the event source if it does not exist
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                    Console.WriteLine("Event source created.");
                }


                // Log an information event
                EventLog.WriteEntry(sourceName, "This is an information event.", EventLogEntryType.Information);
                EventLog.WriteEntry(sourceName, "This is a warning event.", EventLogEntryType.Warning);
                EventLog.WriteEntry(sourceName, "This is an Error event.", EventLogEntryType.Error);


                Console.WriteLine("Event written to the log.");
            }
        }
    }
}
