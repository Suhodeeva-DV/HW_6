using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ping ping = new Ping();
            ping.PingEvent += EventMessage;
            Pong pong = new Pong();
            pong.PongEvent += EventMessage;

            while ((ping.CountPing >= 0) && (pong.CountPong >= 0))
            {
                GamePing(ping);
                Console.WriteLine($"Счёт: {ping.CountPing} : {pong.CountPong}");
                GamePong(pong);
                Console.WriteLine($"Счёт: {ping.CountPing} : {pong.CountPong}");
            }

            while (ping.CountPing == pong.CountPong)
            {
                GamePing(ping);
                Console.WriteLine($"Счёт: {ping.CountPing} : {pong.CountPong}");
                GamePong(pong);
                Console.WriteLine($"Счёт: {ping.CountPing} : {pong.CountPong}");
            }

            if (ping.CountPing < 0)
            {
                Console.WriteLine($"Выйграл Pong! Счёт: {ping.CountPing} : {pong.CountPong} ");
            }
            else
            {
                Console.WriteLine($"Выйграл Ping! Счёт: {ping.CountPing} : {pong.CountPong}");
            }
        }

        static void GamePing(Ping p)
        {
            p.Play();
        }

        static void GamePong(Pong p)
        {
            p.Play();
        }

        static void EventMessage(object sender, PingPongEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
