using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module._10
{
    public interface ICalc<T>
    {
        public T Sum(T a, T b);

        public T GetRightInput();
    }

    public interface ILog
    {
        public void LogEvent(string msg);
        public void LogError(string msg);
    }
}
