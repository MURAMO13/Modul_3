using System.Reflection;
using System.Threading.Channels;
using System.Xml.Linq;

namespace Model_3_1;
class Program
{
    static void Main()
    {
        //// Создаём кортеж
        //(string Name, string Type, double Age) Pet = ("Барсик", "Кошка", 2.5);

        //// Получаем тип кортежа
        //Type tupleType = Pet.GetType();

        //// Перебираем все поля кортежа
        //foreach (var field in tupleType.GetFields(BindingFlags.Instance | BindingFlags.Public))
        //{
        //    // Выводим имя поля и его значение
        //    Console.WriteLine($"{field.Name}: {field.GetValue(Pet)}");
        //}

        Random random = new Random();
        byte[] buffer = new byte[5];
        random.NextBytes(buffer); // Заполнит массив случайными байтами
        Console.WriteLine(string.Join(", ", buffer));



        Console.ReadKey();
    }


   
    

}




