using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementDiagnostics
{
    class EventLogTest
    {
        public static void Execute()
        {
            if (!EventLog.SourceExists("MySource"))
            {
                EventLog.CreateEventSource("MySource", "MyNewLog");
                Console.WriteLine("CreatedEventSource");
                Console.WriteLine("Please restart application");
                Console.ReadKey();
                return;
            }
            EventLog myLog = new EventLog();
            myLog.Source = "MySource";
            myLog.WriteEntry("Log event!");
        }

        public static void WriteExecute()
        {
            EventLog applicationLog = new EventLog("Application", ".", "testEventLogEvent");
            applicationLog.EntryWritten += (sender, e) =>
            {
                Console.WriteLine(e.Entry.Message);
            };
            applicationLog.EnableRaisingEvents = true;
            applicationLog.WriteEntry("Test message", EventLogEntryType.Information);
            Console.ReadKey();
        }
    }
}
