using System.Reflection;
using System.Threading.Channels;
using System.Xml.Linq;

namespace Model_3_1;
class Program
{
    static void Main()
    {
        (string Name, string LastName, string Login, int LoginLenght, bool HasPet, double Age, string[] FavColor)[] Users = new (string, string, string, int, bool, double, string[])[3];


        for (int h = 0; h < Users.Length; h++)
        {
            Console.WriteLine($"User: {h + 1}");

            (string Name, string LastName, string Login, int LoginLenght, bool HasPet, double Age, string[] FavColor) User;


            Console.WriteLine("Enter your name:");
            User.Name = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            User.LastName = Console.ReadLine();

            Console.WriteLine("Enter your username:");
            User.Login = Console.ReadLine();

            User.LoginLenght = User.Login.Length;

            Console.WriteLine("Do you have any animals? Yes or No");
            User.HasPet = Console.ReadLine()?.ToLower() == "yes";//? true : false; 

            Console.WriteLine("Enter your age:");
            User.Age = double.TryParse(Console.ReadLine(), out double age) ? age : 0;

            Console.WriteLine("Enter your three favorite colors:");
            User.FavColor = new string[3];

            for (int i = 0; i < User.FavColor.Length; i++)
            {
                Console.Write($"{i + 1}.  ");
                User.FavColor[i] = Console.ReadLine();
            }

            Users[h] = User;
        }

        for (int h = 0; h < Users.Length; h++)
        {
            Console.WriteLine($"User {h + 1}:");
            var user = Users[h];
            Console.WriteLine($"Name: {user.Name}");
            Console.WriteLine($"Last Name: {user.LastName}");
            Console.WriteLine($"Username: {user.Login}");
            Console.WriteLine($"Login Length: {user.LoginLenght}");
            Console.WriteLine($"Has Pet: {user.HasPet}");
            Console.WriteLine($"Age: {user.Age}");
            Console.WriteLine("Favorite Colors: " + string.Join(", ", user.FavColor));
        }





        Console.ReadKey();
    }


   
    

}




