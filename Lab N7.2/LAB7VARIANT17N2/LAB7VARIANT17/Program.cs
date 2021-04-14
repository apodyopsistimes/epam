using System;
using System.Threading.Tasks;

namespace LAB7VARIANT17
{
   class Program
   {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Ping pong game (by T.E.D.)");
            Console.WriteLine("Press Enter to play");
            Console.ReadLine();

            Ping ping = new Ping();
            Pong pong = new Pong();
            Ping.a a_ping = pong.Otbivanie;
            Pong.b b_pong = ping.Otbivanie;

            ping.OtbilPing += a_ping;
            pong.OtbilPong += b_pong;
            ping.Otbivanie();
            pong.Otbivanie();
        }
   }
   class Pong
   {
        public delegate void b();
        public event b OtbilPong;
        public void Otbivanie()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Task.Delay(TimeSpan.FromSeconds(0.5)).Wait();
            Console.WriteLine("Pong received Ping");
            if (OtbilPong != null)
                OtbilPong();
        }
   }
    class Ping
    {
        public delegate void a();
        public event a OtbilPing;
        public void Otbivanie()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Task.Delay(TimeSpan.FromSeconds(0.5)).Wait();
            Console.WriteLine("Ping received Pong");
            if (OtbilPing != null)
                OtbilPing();
        }
    }
}