using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLogTest
{
    class Program
    {
        static void Main(string[] args)
        {
            EventLog myLog = new EventLog();
            EventLog.CreateEventSource("MySourc2e", "MyNewLog");
            myLog.Log = "MyNewLog";
            foreach (EventLogEntry entry in myLog.Entries)
            {
                Console.WriteLine("\tEntry: " + entry.Message);
            }

            //if (!EventLog.SourceExists("MySource"))
            //{
            //    EventLog.CreateEventSource("MySource", "MyNewLog");
            //    Console.WriteLine("CreatingEventSource");
            //}

            //EventLog myLog = new EventLog();
            //myLog.Source = "MySource";

            //myLog.WriteEntry("Msg : Writing to event log.");
        }
    }
}
