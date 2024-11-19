namespace Model_3_1;
class Program
{
    static void Main()
    {

        int sum = 0;

        while (true)
        {
            Console.WriteLine("Введите число");
            var number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                continue;
            }
            else if (number == 0)
            {
                break;
            }

            // number > 0
            sum += number;
        }

        Console.WriteLine("Итоговая сумма: {0}", sum);




        Console.ReadKey();
    }
}




