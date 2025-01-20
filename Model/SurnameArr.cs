using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal static class SurnameArr
    {
        static string[] surnameArr = { "Яшев","Иванов","Марков","Алаев","Бабаева" };

        public static void PrintInConsole() => Console.WriteLine(string.Join(Environment.NewLine,surnameArr));

        public static void SortAY() 
        { 
            Array.Sort(surnameArr); 

            PrintInConsole();

            Program.EventInvoked = true;
        }

        public static void SortYA()
        {
            Array.Sort(surnameArr);
            Array.Reverse(surnameArr);

            PrintInConsole();

            Program.EventInvoked = true;
        }
    }
}
