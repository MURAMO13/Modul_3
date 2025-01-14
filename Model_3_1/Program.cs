using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Model
{
    delegate void TypeOfSort();
    

    class Program
    {
        public static event TypeOfSort SortAY;
        public static event TypeOfSort SortYA;

        public static bool EventInvoked;

        static void Main()
        {
            int SortNum = 0;

            SortAY += SurnameArr.SortAY;
            SortYA += SurnameArr.SortYA;

            Dictionary<int,TypeOfSort> typeOfSortsD = new Dictionary<int, TypeOfSort> { { 1,SortAY },{ 2,SortYA } };

            SurnameArr.PrintInConsole();

            Console.WriteLine();
            Console.WriteLine("Enter number for sort the list of surname: \n 1 - [А-Я] \n 2 - [Я-А] \n");
            
            while (!EventInvoked) 
            {
                try
                {
                    SortNum = Convert.ToInt32(Console.ReadLine());

                    typeOfSortsD[SortNum].Invoke();

                    //if (SortNum == 1) { SurnameArr.SortAY(); }
                    //else if (SortNum == 2) { SurnameArr.SortYA(); }
                    //else { Console.WriteLine("\nEnter number again for sort the list of surname: \n 1 - [А-Я] \n 2 - [Я-А] \n"); }
                }
              
                catch (Exception ex)
                {
                    Exception? matchedException = Array.Find(Exceptions.exceptions, e => e.GetType() == ex.GetType());

                    if (matchedException != null)
                    {
                        Console.WriteLine($"Стандартное исключени найдено:{ex.Message} ");
                    }
                    else
                    {
                        Console.WriteLine($"Пользовательское мсключение:{ex.GetType().Name}.\n Сообщение: {ex.Message}");
                    }

                    //Console.WriteLine("\nEnter number again for sort the list of surname: \n 1 - [А-Я] \n 2 - [Я-А] \n");
                    //Console.WriteLine(ex.ToString());
                }
            }

            Console.WriteLine();

            Exceptions.PrintAllExc();

            Console.ReadLine();
        }

        
    }

     
}

