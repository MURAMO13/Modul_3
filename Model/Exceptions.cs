using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal static class Exceptions
    {
        public static Exception[] exceptions = new Exception[]
        {
            new ArgumentException ("Аргумент NULL!"),
            new ArgumentOutOfRangeException ("Аргумент находится за пределами диапозона допустимых значений!"),
            new KeyNotFoundException ("Не удается найти указанный ключ для доступа к элементу в коллекции!"),
            new OverflowException ("Арифметическое, приведение или операция преобразования приводят к переполнению!"),
            new ExceptionExtensions ("Пользовательское исключение. Есть ошибка!")

        };

        public static void PrintAllExc() 
        {
            foreach (var ex in exceptions)
            {
                try
                {
                    throw ex;
                }
                catch (Exception exc)
                {

                    Console.WriteLine($"Искллючение:{exc.GetType().Name}.\n Сообщение: {exc.Message}  ");
                }
                
            }
        }
    }

    internal class ExceptionExtensions : Exception
    {
        public ExceptionExtensions(string exc) : base(exc)
        {
            Console.WriteLine (exc);
        }
    }


}
