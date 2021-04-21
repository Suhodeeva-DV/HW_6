using System;

namespace HW_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter account = new Counter();

            account.Notify += CounterDelegate;
            account.Notify2 += CounterDelegate2;
            account.Count();
        }

        static void CounterDelegate(object sender, Handler1 e)
        {
            Console.WriteLine(e.Message);
        }

        static void CounterDelegate2(object sender, Handler2 e)
        {
            Console.WriteLine(e.Message);
        }

    }
}
