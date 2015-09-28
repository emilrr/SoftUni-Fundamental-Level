using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.AsynchronousTimer
{
    class AsynchronousTimerMain
    {
        static void Main()
        {
            AsyncTimer timer1 = new AsyncTimer(WorkFirst, 1000, 10);
            timer1.Start();

            AsyncTimer timer2 = new AsyncTimer(WorkSecond, 400, 20);
            timer2.Start();
        }

        public static void WorkFirst(string str)
        {
            Console.WriteLine(str);
        }

        public static void WorkSecond(string str)
        {
            Console.Beep();
        }
    }
}
