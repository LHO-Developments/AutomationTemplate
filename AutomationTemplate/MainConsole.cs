using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTemplate.Utility;
using AutomationTemplate.Logger;

using System.Runtime.InteropServices;
namespace AutomationTemplate
{
    public class MainConsole
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static void Main()
        {
         /*   
            Console.WriteLine("test");
            string ver = AppDomain.CurrentDomain.SetupInformation.TargetFrameworkName;
            log.Info("Start:");
            log.Info("Testing 123: " + ver);
            log.Error("Testing 1234: " + ver);
            log.Warn("Testing 12345: " + ver);
            log.Fatal("Testing 123467: " + ver);
            log.Info("END:");
            //log.Error("This is a test");
            Console.ReadLine();*/
        }
    }
}
