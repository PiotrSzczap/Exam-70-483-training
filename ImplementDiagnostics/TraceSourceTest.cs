using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementDiagnostics
{
    class TraceSourceTest
    {
        static void Execute()
        {
            TraceSource traceSource = new TraceSource("myTraceSource", SourceLevels.All);
            traceSource.TraceInformation("Tracing application..");
            traceSource.TraceEvent(TraceEventType.Critical, 0, "Critical trace");
            traceSource.TraceData(TraceEventType.Information, 1,
            new object[] { "a", "b", "c" });
            traceSource.Flush();
            traceSource.Close();
            // Outputs:
            // myTraceSource Information: 0 : Tracing application..
            // myTraceSource Critical: 0 : Critical trace
            // myTraceSource Information: 1 : a, b, c
        }
    }
}
