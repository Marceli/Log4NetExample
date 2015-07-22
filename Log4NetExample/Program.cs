using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using log4net;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Log4NetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ILog log=LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            var i = 0;
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    break;
                }
                log.Error(i+1);
               
                i++;
                Thread.Sleep(1000);


            }
        }
    }
}
