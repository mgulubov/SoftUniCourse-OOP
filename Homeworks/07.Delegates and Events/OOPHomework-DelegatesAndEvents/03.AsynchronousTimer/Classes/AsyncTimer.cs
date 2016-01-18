using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AsynchronousTimer.Classes
{
    class AsyncTimer
    {
        private int Ticks { set; get; }
        private int Interval { set; get; }
        private Action Action { set; get; }

        public AsyncTimer(int ticks, int interval, Action act) 
        {
            this.Ticks = ticks;
            this.Interval = interval;
            this.Action = act;
        }

        public void Run()
        {
            for (int i = 0; i < this.Ticks; i++)
            {
                int count = 0;
                while (count < this.Interval)
                {
                    count++;
                }
                this.Action.Invoke();
            }
        }
    }
}
