using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module._10
{
    public class Screen
    {
        private ICalc<decimal> calc;
        private ILog log;

        public Screen(ICalc<Decimal> Calc,ILog Log) 
        {
            calc = Calc;
            log = Log;
        }
        public void WorkBro() 
        {
            while (true)
            {
                Console.WriteLine("\n");
                log.LogEvent("Let's calculate amount\n");
                log.LogEvent("Fist num ...");
                var fistNum = calc.GetRightInput();

                log.LogEvent("Second num ...");
                var secondnum = calc.GetRightInput();

                

                var sum = calc.Sum(fistNum, secondnum);
                log.LogEvent($"Result is: {sum}");

                log.LogEvent("Log list:  \n\n\n");
                LogStorage.ShowLog();
                Console.ReadLine();
            }
        }
    }
    public class Calc : ICalc<decimal>
    {
        private ILog log;

        public Calc(ILog Log) 
        {
            log = Log;
        }
        public decimal Sum(decimal a, decimal b)
        {
            return a + b;
        }

        public decimal GetRightInput()
        {

            while (true)
            {
                try
                {

                    string? input = Console.ReadLine();
                    if (Decimal.TryParse(input, out decimal result))
                    {
                        log.LogEvent("We accept this number! \n Cool!");
                        
                        return result;
                    }
                    log.LogError("Entered number is wrong \n Try again ...");
                }
                catch (Exception ex)
                {
                    log.LogError($"Enter number is wrong:{ex.Message} \n Try again ...");
                }

            }


        }
    }

    public class Log : ILog
    {
        public void LogError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"Error: {msg}");

            LogStorage.AddLog(msg);
        }

        public void LogEvent(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine($"Event: {msg}");

            LogStorage.AddLog(msg);
        }
    }

    public static class LogStorage
    {
        private static Dictionary<DateTime,string> LogStorageDic = new Dictionary<DateTime,string>();

        public static void AddLog(string msg) 
        {
            LogStorageDic.Add(DateTime.Now, msg);
        }

        public static void ShowLog() 
        {
            foreach (var log in LogStorageDic)
            {
                Console.WriteLine($"{log.Key}:  {log.Value}");
            }
        }
    }
}
