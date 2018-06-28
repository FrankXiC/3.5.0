using log4net.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using log4net;

namespace TESTABP
{
    public class SDKProperties
    {
        public static ILoggerRepository LogRepository { get; set; }
    }

    public class Base
    {
        private static readonly ILog log = LogManager.GetLogger(SDKProperties.LogRepository.Name, typeof(Base));

        public static void LogTest()
        {
            log.Info("Info test");
            log.Warn("Warn test");
            log.Error("Error test");
        }

    }
}
