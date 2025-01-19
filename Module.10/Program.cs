namespace Module._10
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ILog loger = new Log();

            ICalc<decimal> calc = new Calc(loger);

            

            Screen screen6X4 = new Screen(calc,loger);
            screen6X4.WorkBro();
        }
    }

   
}
