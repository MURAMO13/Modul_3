using System.Reflection;
using System.Threading.Channels;
using System.Xml.Linq;

namespace Model_3_1;
class Program
{
    static void Main()
    {

        var ArrToSort = GetArrayFromConsole();
        var SortedArr = SortArr(ArrToSort);



        Console.ReadKey();
    }

    static int[] GetArrayFromConsole()
    {
        var result = new int[5];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);


            result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }

    static int[] SortArr( int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++) // Внешний цикл
        {
            for (int j = 0; j < array.Length - i - 1; j++) // Внутренний цикл
            {
                if (array[j] > array[j + 1]) // Сравнение соседних элементов
                {
                    // Обмен элементов
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;

                    // Отладочный вывод
                    foreach (var item in array)
                    {
                        Console.Write(item + "  ");
                    }
                    Console.WriteLine();
                }
            }
        }

        return array;
    }




}




