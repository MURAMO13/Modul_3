namespace Model_3_1;
class Program
{
    static void Main()
    {
        while (true)
        {
            var temp =int.Parse( Console.ReadLine() );
            Console.WriteLine( temp.GetNegative() );
            Console.WriteLine( temp.GetPositive() );
        }
       
    }

}

class BaseClass
{
    protected string Name;

    public BaseClass(string name) 
    {
        Name = name;
    }

   protected virtual void Display()
   {
        Console.WriteLine("Hello from BaseClass");  
   }

    protected virtual int Counter { get; set; }
}

class DerivedClass : BaseClass
{
    public string Description;

    public int counter;
    public DerivedClass (string name, string description) : base(name)
    {
        Description = description;
    }

    public DerivedClass(string name, string description, int counter) : this(name, description)
    {
        Counter = counter;
    }

    protected override void Display()
    {
        Console.WriteLine("Hello from DerivedClass");
    }

    
    protected override int Counter 
    { 
        get => counter ;
        set 
        {
            if (value >= 0)
            {
                Counter = value;

            }
            else { Console.WriteLine(" U input wrong int"); }
        } 
    }
}

class Ob 
{
    public int Value;

    public static Ob operator + (Ob a, Ob b) 
    {
        return new Ob {Value = a.Value + b.Value };
    }

}

class HelloIndex
{
    public int[] arr;
    public HelloIndex(int[] arr)
    {
        this.arr = arr;
    }

    public int this[int v] 
    {
        get
        {
            return arr[v];
        }
        set 
        {
            arr[v] = value;
        }
    }
}

static class newint
{
    public static int GetNegative(this int source) 
    {
        return source <= 0 ? source  : -source;

    }

    public static int GetPositive(this int source)
    {
        return source >= 0 ? source : -source;

    }
}

