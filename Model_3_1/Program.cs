using System.Reflection;
using System.Threading.Channels;
using System.Xml.Linq;

namespace Model_3_1;
class Program
{
    static void Main()
    {
        int[] ArrayMain = { 1, 2, -2, 8, 0, 100, -100 };
        int[] ArrByDesc; // По убыванию
        int[] ArrByAsc; // По возрастанию

        SortArray(ArrayMain, out ArrByDesc, out ArrByAsc);
        Console.WriteLine( string.Join("  ", ArrByDesc) );
        Console.WriteLine( string.Join("  ",ArrByAsc) );
        Console.ReadKey();
    }
    static void SortArray( int[]arrayMain, out int[] arrbydecs, out int[] arrbyasc) 
    {
        arrbydecs = SortArrayDesc((int[]) arrayMain.Clone());
        arrbyasc = SortArrayAsc((int[])arrayMain.Clone());

    }
    static int[] SortArrayAsc(int[] arr ) 
    {
        for (int i = 0;i< arr.Length - 1; ++i) 
        {
            for (int j = 0; j < arr.Length - 1 - i; ++j)
            {
                if (arr[j] > arr[j+1])
                {
                    var temp = arr[j];
                    arr[j] = arr[j+1]; 
                    arr[j+1] = temp;
                }
            }

        }
        return arr;
    }

    static int[] SortArrayDesc(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; ++i)
        {
            for (int j = 0; j < arr.Length - 1 - i; ++j)
            {
                if (arr[j] < arr[j + 1])
                {
                    var temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }

        }
        return arr;
    }



}




