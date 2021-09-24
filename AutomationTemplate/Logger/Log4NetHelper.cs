using System;
using System.Collections.Generic;
using log4net;

namespace AutomationTemplate.Logger
{
    public class Log4NetHelper
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Log4NetHelper()
        {
        }

    }
}