using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
    class Handler1 : EventArgs
    {
        public string Message { get; } 

        public Handler1(string mes)
        {
            Message = mes;
        }
    }
}
