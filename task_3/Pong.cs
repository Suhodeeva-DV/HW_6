using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Pong
    {
        public EventHandler<PingPongEventArgs> PongEvent;

        public int CountPong { get; set; } = 0;
        
        public static Random rnd = new Random();

        public void Play()
        {
            int magicRandom = rnd.Next(1, 20);
            if (magicRandom < 11)
            {
                CountPong++;
                PongEvent?.Invoke(this, new PingPongEventArgs("Pong получил Ping"));
            }
            else
            {
                CountPong--;
                PongEvent?.Invoke(this, new PingPongEventArgs("Pong промахнулся"));
            }
        }
    }
}
