using System;
using System.Threading;

namespace _03.AsynchronousTimer
{
    class AsyncTimer
    {
        private readonly Action<string> actionMethod;
        private int ticks;
        private int interval;

        public AsyncTimer(Action<string> actionMethod, int interval, int ticks)
        {
            this.Ticks = ticks;
            this.Interval = interval;
            this.actionMethod = actionMethod;
        }

       
        public int Ticks
        {
            get { return this.ticks; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("ticks", "The method should be executed at least once.");
                }
                this.ticks = value;
            }
        }

        public int Interval
        {
            get { return this.interval; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("interval", "Interval cannot be negative.");
                }
                this.interval = value;
            }
        }

        private void DoWork()
        {
            while (this.ticks > 0)
            {
                Thread.Sleep(this.interval);

                if (actionMethod != null)
                {
                    actionMethod(this.ticks + "");
                }

                this.ticks--;
            }
        }

        public void Start()
        {
            Thread thread = new Thread(this.DoWork);
            thread.Start();
        }

    }
}
