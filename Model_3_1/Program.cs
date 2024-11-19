namespace Model_3_1;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите своё имя:");
        var name = Console.ReadLine();

        foreach (var item in name)
        {
            Console.Write(item + " ");
        }

        Console.Write("Последная буква вашего имени:" + name[name.Length-1]);




        Console.ReadKey();
    }
}




