using System.Threading.Channels;

namespace Model_3_1;
class Program
{
    static void Main()
    {
        int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };


        int negative = 0, 
            positive = 0;

        foreach (var i in arr)
        {
            
            if ( i > 0) 
            {
                positive++;
            }
            else if (i < 0)
            {
                negative++;
            }
        }
        Console.WriteLine(negative);
        Console.WriteLine(positive);
       




        Console.ReadKey();
    }


   
    

}




