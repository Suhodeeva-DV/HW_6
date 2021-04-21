using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
    class Handler2 : EventArgs
    {
        public string Message { get; }

        public Handler2(string mes)
        {
            Message = mes;
        }
    }
}
