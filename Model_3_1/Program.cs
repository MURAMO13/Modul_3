using System.Threading.Channels;

namespace Model_3_1;
class Program
{
    static void Main()
    {
        int[][] array = new int[3][];
        array[0] = new int[2] { 1, 2 };
        array[1] = new int[3] { 1, 2, 3 };
        array[2] = new int[5] { 1, 2, 3, 4, 5 };

        foreach (int [] i in array) 
        {
            foreach (int j in i)
            {
                Console.Write(j+"  ");
            }
            Console.WriteLine();

        }  




        Console.ReadKey();
    }


   
    

}




