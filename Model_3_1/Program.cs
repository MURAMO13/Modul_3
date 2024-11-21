using System.Threading.Channels;

namespace Model_3_1;
class Program
{
    static void Main()
    {
        var arr = new int[] { 5, -88, 9, 0, 2, 3, 4 };
        var sum = 0;
        foreach (int i in arr) 
        {
            sum += i;
            Console.WriteLine(sum);
        }





        Console.ReadKey();
    }


   
    static void forich_show(int[]arrt) 
    {
        foreach (var item in arrt)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

}




