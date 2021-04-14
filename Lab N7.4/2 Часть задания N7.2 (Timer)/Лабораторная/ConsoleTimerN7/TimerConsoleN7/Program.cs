using System;
using System.Threading;

namespace ConsoleTimerN7
{
    class Program
    {
        static void Main(string[] args)
        {
            ICutDownNotifier[] interfaceArray = new ICutDownNotifier[3];
            ReversTimer[] RtArray = new ReversTimer[3];

            Console.Write("Введите имя первого таймера: ");
            RtArray[0] = new ReversTimer(Console.ReadLine());
            Console.Write("Установите время: ");
            interfaceArray[0] = new TimerMethod(Convert.ToInt32(Console.ReadLine()));

            Console.Write("Введите имя второго таймера: ");
            RtArray[1] = new ReversTimer(Console.ReadLine());
            Console.Write("Установите время: ");
            interfaceArray[1] = new TimerMethod(Convert.ToInt32(Console.ReadLine()));

            Console.Write("Введите имя третьего таймера: ");
            RtArray[2] = new ReversTimer(Console.ReadLine());
            Console.Write("Установите время: ");
            interfaceArray[2] = new TimerMethod(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            for (int i = 0; i < interfaceArray.Length; i++)
            {
                interfaceArray[i].init(RtArray[i]);
                interfaceArray[i].Run(RtArray[i]);
                Console.WriteLine();
            }

        }
    }

    public class ReversTimer
    {
        public delegate void timerStart(string source, string name);
        public event timerStart start;

        public delegate void timerLeft(string source, string name, int N);
        public event timerLeft left;

        public delegate void timerEnd(string source, string name);
        public event timerEnd end;

        public string name { get; set; }

        public ReversTimer(string name)
        {
            this.name = name;
        }
        public void go(int wait)
        {
            start?.Invoke("timer", this.name);
            for (int i = wait; i > 0; i--)
            {
                Thread.Sleep(1000);
                left?.Invoke("timer", this.name, i);
            }
            end?.Invoke("timer", this.name);
        }
    }

    public interface ICutDownNotifier
    {
        void init(ReversTimer RtInit);
        void Run(ReversTimer RtRun);
    }

    class TimerMethod : ICutDownNotifier
    {
        int time;
        public TimerMethod(int time)
        {
            this.time = time;
        }
        public void init(ReversTimer RtInit)
        {
            RtInit.start += Starting;
            RtInit.left += Waiting;
            RtInit.end += TheEnd;
        }

        public void Run(ReversTimer RtInit)
        {
            RtInit.go(time);
        }

        public void Starting(string source, string name)
        { Console.WriteLine($"Старт обратного отсчёта {name}:"); }

        private void Waiting(string source, string name, int N)
        { Console.WriteLine($"У таймера {name} осталось секунд: {N} "); }

        private void TheEnd(string source, string name)
        { Console.WriteLine("Обратный отсчёт завершён"); }

    }

    class TimerAnonMethod : ICutDownNotifier
    {
        int time;
        public TimerAnonMethod(int time)
        {
            this.time = time;
        }
        public void init(ReversTimer RtInit)
        {
            RtInit.start += delegate (string source, string name)
            { Console.WriteLine($"Старт обратного отсчёта {name}:"); };

            RtInit.left += delegate (string source, string name, int N)
            { Console.WriteLine($"У таймера {name} осталось секунд: {N} "); };

            RtInit.end += delegate (string source, string name)
            { Console.WriteLine("Обратный отсчёт завершён"); };
        }

        public void Run(ReversTimer RtRun)
        {
            RtRun.go(time);
        }

    }

    class TimerLambdas : ICutDownNotifier
    {
        int time;
        public TimerLambdas(int time)
        {
            this.time = time;
        }
        public void init(ReversTimer RtInit)
        {
            RtInit.start += (string source, string name) => { Console.WriteLine($"Старт обратного отсчёта {name}:"); };
            RtInit.left += (string source, string name, int N) => { Console.WriteLine($"У таймера {name} осталось секунд: {N} "); };
            RtInit.end += (string source, string name) => { Console.WriteLine("Обратный отсчёт завершён"); };
        }

        public void Run(ReversTimer RtRun)
        {
            RtRun.go(time);
        }

    }
}
