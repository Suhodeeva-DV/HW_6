using System;

namespace HW_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        public static void Test()
        {
            Counter account = new Counter();

            account.Notify += CounterDelegate;
            account.Notify2 += CounterDelegate2;

            static void CounterDelegate(object sender, Handler1 e)
            {
                Console.WriteLine(e.Message);
            }

            static void CounterDelegate2(object sender, Handler2 e)
            {
                Console.WriteLine(e.Message);
            }

            account.Count();
        }
    }
}
