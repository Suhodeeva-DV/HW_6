using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Ping
    {
        public EventHandler<PingPongEventArgs> PingEvent;

        public int CountPing { get; set; } = 0;

        public static Random rnd = new Random();

        public void Play()
        {
            int magicRandom = rnd.Next(1, 20);
            if (magicRandom > 10)
            {
                CountPing++;
                PingEvent?.Invoke(this, new PingPongEventArgs("Ping получил Pong"));
            }
            else
            {
                CountPing--;
                PingEvent?.Invoke(this, new PingPongEventArgs("Ping промахнулся"));
            }
        }
    }


}
