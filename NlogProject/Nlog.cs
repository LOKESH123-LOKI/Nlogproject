using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogProject
{
    public class Nlog
    {
        public Logger Logger=new Logger();
        public void LogInfo(string message)
        {
            Logger.Info(message);
        }
        public void LogWarn(string message)
        {
            Logger.Warn(message);
        }
        public void LogDbug(string message)
        {
            Logger.Debug(message);
        }
        public void LogError(string message)
        {
            Logger.Error(message);
        }
    }
}
