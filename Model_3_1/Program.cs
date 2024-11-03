namespace Model_3_1;
class Program
{
    static void Main()
    {
        Console.Write( "Введите имя: " );
        var name = Console.ReadLine();

        Console.Write( "Введите возраст: " );
        var age = Convert.ToInt32( Console.ReadLine() );

        Console.WriteLine( $"Ваше имя: {name} и вам {age} лет!" );

        Console.Write("Когда вы родились? ");
        var born_date = Console.ReadLine();

        Console.WriteLine( $"Ваш день рождения: {born_date}" );
        




        Console.ReadKey();
    }
}
