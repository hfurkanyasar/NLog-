using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLogSample
{
    public class LoggerManeger : ILoggerManeger
    {
        Logger log = NLog.LogManager.GetLogger("*");
        public void LogError(string ErrorMessage)
        {
            log.Error(ErrorMessage);
        }
        public void LogInfo(string ErrorMessage)
        {
            log.Info(ErrorMessage);
        }
        public void LogLimitAsimi(string ErrorMessage)
        {
            log.Debug(ErrorMessage);
        }
    }
}
