using System.Threading.Channels;

namespace Model_3_1;
class Program
{
    static void Main()
    {
        int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

        var l1 = array.GetUpperBound(0) + 1;
        var l2 = array.GetUpperBound(1) + 1;

        for (int i = 0; i < l2; i++)
        {
            
            for (int k = 0 ; k < l1; k++ )
                Console.Write(array[k, i] + " ");

            

            Console.WriteLine();
        }


        Console.ReadKey();
    }




    public void cw(string some) { Console.WriteLine(some); }

}




