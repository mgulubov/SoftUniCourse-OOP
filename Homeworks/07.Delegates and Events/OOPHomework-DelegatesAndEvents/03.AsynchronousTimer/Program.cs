using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using _03.AsynchronousTimer.Classes;

namespace _03.AsynchronousTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Action timerAct = delegate()
            {
                Console.WriteLine("This is within the Timer class");
            };

            Action mainAct = delegate()
            {
                Console.WriteLine("This is within the Main class");
            };

            AsyncTimer timer = new AsyncTimer(10, 30000, timerAct);

            Thread thread = new Thread(new ThreadStart(timer.Run));
            thread.Start();

            for (int i = 0; i < 10; i++)
            {
                int count = 0;
                while (count < 30000)
                {
                    count++;
                }
                mainAct.Invoke();
            }
        }
    }
}
