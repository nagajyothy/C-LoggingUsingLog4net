using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLog4netEx
{
    class Program
    {
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("LogFileLogger");
        private static readonly log4net.ILog Sqllog = log4net.LogManager.GetLogger("AdoNetAppender");
        
        static void Main(string[] args)
        {
            log.Info("Hello logging world!");

            Sqllog.Error("sample error message");
            Console.WriteLine("Hit enter");
            Console.ReadLine();
        }
    }
}
