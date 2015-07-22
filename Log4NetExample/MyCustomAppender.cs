using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Core;
using log4net.Appender;

namespace Log4NetExample
{
    public class MyCustomAppender : AppenderSkeleton
    {
        protected override void Append(LoggingEvent loggingEvent)
        {
            string message = RenderLoggingEvent(loggingEvent);
            Console.Write("From Custom Appender" + message);
        }
    }
}
