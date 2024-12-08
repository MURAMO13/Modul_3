

namespace Model_3_1;
class Program
{
    static void Main()
    {

        var User = GetInfoUser();

        WatchUser(User);



        Console.ReadKey();
    }
    static (string FirstName, string LastName, int age, bool HasPet, string[] PetsArrName, string[] FavArrCol) GetInfoUser()
    {

        (string FirstName, string LastName, int age, bool HasPet, string[] PetsArrName, string[] FavArrCol) user;
        Console.WriteLine("What is your name?");
        user.FirstName = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        user.LastName = Console.ReadLine();

        Console.WriteLine("How old are you?");
        user.age = CorrectInt();

        Console.WriteLine("Do you have pets? \n Yes or No.");
        user.HasPet = CorectBool();
        if (user.HasPet)
        {
            Console.WriteLine("How many pets do you have?");
            user.PetsArrName = FillArrs(new string[CorrectInt()]);
        }
        else
        {
            user.PetsArrName = Array.Empty<string>();
        }

        Console.WriteLine("How many favorite colors do you have?");
        user.FavArrCol = FillArrs(new string[CorrectInt()]);

        return user;
    }

    static bool CorectBool()
    {
        string input = Console.ReadLine().ToLower();
        if (input == "yes")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static int CorrectInt()
    {
        int NaturelNum;

        while (true)
        {
            var input = Console.ReadLine();
            if (int.TryParse(input, out NaturelNum) && NaturelNum > 0)
            {
                return NaturelNum;
            }
            else
            {
                Console.WriteLine("Try again! \n And enter correct number");
            }
        }

    }

    static string[] FillArrs(string[] arrToFill)
    {
        for (int i = 0; i < arrToFill.Length; ++i)
        {
            Console.WriteLine($"Enter {i+1} item: ");
            arrToFill[i] = Console.ReadLine();
        }
        return arrToFill;
    }

    static void WatchUser((string FirstName, string LastName, int age, bool HasPet, string[] PetsArrName, string[] FavArrCol) user) 
    {
        Console.WriteLine($"User name: {user.FirstName}");
        Console.WriteLine($"User last name:{user.LastName}");
        Console.WriteLine($"User age:{user.age}");
      
        if (user.HasPet && user.PetsArrName.Length > 0)
        {
            Console.WriteLine("Pets: ");
            foreach (var item in user.PetsArrName)
            {
                Console.WriteLine($"\t {item}");
            }
        }
        else 
        {
            Console.WriteLine("You have not pets!");
        }

        if (user.FavArrCol.Length > 0)
        {
            Console.WriteLine("Your favorite colors");
            foreach (var item in user.FavArrCol)
            {
                Console.WriteLine($"\t {item}");
            }
        }
        else
        {
            Console.WriteLine("The user has not listed any favorite colors.");
        }
    }

}




