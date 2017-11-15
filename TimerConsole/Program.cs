using System;
using Homework;

namespace TimerConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var john = new Listener1("John");
            john.NotifyMe("docs are ready", 10);

            var stephen = new Listener2("Stephen");
            stephen.NotifyMe("go to school", 5);

            Console.Read();
        }

        private abstract class Listener
        {
            private string name;

            protected Listener(string name)
            {
                this.name = name;
            }

            protected string Name { get => name; set => name = value; }

            public virtual void NotifyMe(string message, byte seconds)
            {
                var timer = new Timer(message, seconds);
                timer.Signal += SignalReceived;
                timer.StartCountdown();
            }

            private void SignalReceived(object sender, Timer.SignalEventArgs e)
            {
                Console.WriteLine($"{e.Now.ToLocalTime()}: {e.Message}");
            }
        }

        private class Listener1 : Listener
        {
            public Listener1(string name) : base(name)
            {
            }

            public override void NotifyMe(string message, byte seconds)
            {
                base.NotifyMe($"{Name}, {message}", seconds);
            }
        }

        private class Listener2 : Listener
        {
            public Listener2(string name) : base(name)
            {
            }

            public override void NotifyMe(string message, byte seconds)
            {
                base.NotifyMe($"{message}, {Name}!", seconds);
            }
        }
    }
}
