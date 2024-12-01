using System.Reflection;
using System.Threading.Channels;
using System.Xml.Linq;

namespace Model_3_1;
class Program
{
    static void Main()
    {
        Console.WriteLine(" Enter somethring ");
        var EchoText = Console.ReadLine();

        var DepthInt = EchoText.Length;

        EchoTextMethod(EchoText, DepthInt);



        Console.ReadKey();
    }

    static void EchoTextMethod(string text, int depht)
    {
        if (depht > 0)
        {
            Console.WriteLine("  >>>" + text);
            EchoTextMethod(text.Remove(0, 1), depht - 1);
        }
    }

}




