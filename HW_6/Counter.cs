using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
    class Counter
    {
        public delegate void CounterDelegateWithArgs(object sender, Handler1 e);
        public delegate void CounterDelegateWithArgs2(object sender, Handler2 e);

        public event CounterDelegateWithArgs Notify;
        public event CounterDelegateWithArgs2 Notify2;

        private int count { get; set; } = 0;

        public void Count()
        {
            for (int i = 1; i <= 100; i++)
            {
                count++;

                if (count == 77)
                {
                    Notify?.Invoke(this, new Handler1("Пора действовать, ведь уже 77"));
                    Notify2?.Invoke(this, new Handler2("Уже 77, давно пора было начать!"));
                }
            }
        }
        

    }
}
