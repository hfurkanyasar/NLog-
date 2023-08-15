using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLogSample
{
    public interface ILoggerManeger
    {
        void LogError(string ErrorMessage);
        void LogInfo(string ErrorMessage);
        void LogLimitAsimi(string ErrorMessage);

    }
}
