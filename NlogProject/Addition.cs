using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogProject
{
    public class Addition
    {
        Nlog nlog = new Nlog();
        public void Sum(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                nlog.LogInfo("Info:Sum()");
                nlog.LogWarn("Warn: a or b is 0");
                nlog.LogError("Error:Either a or b is 0");
            }
            int c = a + b;
            nlog.LogInfo("Infor:Sum()");
            nlog.LogDbug("Debug:Sum()" + c);
        }
    }
}
