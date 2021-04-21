using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    public class PingPongEventArgs : EventArgs
    {
        public string Message;
        public PingPongEventArgs(string mes)
        {
            Message = mes;
        }
    }
}
