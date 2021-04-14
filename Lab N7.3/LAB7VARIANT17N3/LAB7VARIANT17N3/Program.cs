using System;

namespace LAB7VARIANT17N3
{
    class Program
    {
        static void Main(string[] args)
        {
            var signal = new Signaller();

            
            signal.Signaled += Event1;
            signal.Signaled += Event2;
            signal.Signaled += Event3;

            
            Console.WriteLine("Первый сигнал");
            signal.OnSignal();

            Console.WriteLine("Второй сигнал");
            signal.OnSignal();


            Console.ReadKey();
        }

        private static void Event1(out bool eve1)
        {
            eve1 = true;
            Console.WriteLine("Event1 Сообщение принято, уведомляю Event2");
        }

        private static void Event2(out bool eve2)
        {
            eve2 = true;
            Console.WriteLine("Event2 Сообщение принято, уведомляю Event3");
        }

        private static void Event3(out bool eve3)
        {
            eve3 = false;
            Console.WriteLine("Event3 Сообщение не принято и дальше уведомлять другие не будет -_-");
        }
    }

    class Signaller
    {
        public delegate void SignalHandler(out bool eve);

        public event SignalHandler Signaled;

        public void OnSignal()
        {
          
            if (Signaled != null)
                foreach (var handler in Signaled.GetInvocationList())
                {
                    var args = new object[1];
                    handler.Method.Invoke(handler.Target, args);
                    if (!(bool)args[0])                       
                        Signaled -= (SignalHandler)handler;   
                }
        }
    }
}