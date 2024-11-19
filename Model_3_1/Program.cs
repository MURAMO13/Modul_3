namespace Model_3_1;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите своё имя:");
        var name = Console.ReadLine();

        for (int i = name.Length - 1; i > -1 ; i--) 
        {
            Console.Write(name[i] + " ");
        }

       

        Console.Write("Последная буква вашего имени:" + name[name.Length-1]);




        Console.ReadKey();
    }
}




