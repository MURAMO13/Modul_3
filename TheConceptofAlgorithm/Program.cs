using TheConceptofAlgorithm.AdditionalClasses;
namespace TheConceptofAlgorithm;
class Program
{
    static void Main()
    {
        List<User> users = new List<User>
        {
            new User { Login = "user1", Name = "Иван", IsPremium = true },
            new User { Login = "user2", Name = "Анна", IsPremium = false },
            new User { Login = "user3", Name = "Макс", IsPremium = true },
            new User { Login = "user4", Name = "Мария", IsPremium = false }
        };

        foreach (var user in users)
        {
            Console.WriteLine($"Здравствуйте, {user.Name}!");

            if (!user.IsPremium)
            {
                ShowAds();
            }
        }
    }

    static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        Thread.Sleep(3000);
    }
}
