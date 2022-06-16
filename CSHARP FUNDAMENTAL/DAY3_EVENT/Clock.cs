using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAY3_EVENT
{
    public class Clock
    {
        private int Hour ;
        private int Minute ;
        private int Second ;
        public delegate void clockTick(object clock, TimeInfoEventArgs timeInfoEvent );
        
        public event clockTick clockTickEvent;
        public void OnTick(object clock, TimeInfoEventArgs timeInfoEvent)
        {
            if (clockTickEvent != null)
            {
                clockTickEvent(clock,timeInfoEvent);
            }
        }
        public void Run()
        {
            while(!Console.KeyAvailable)
            {
                Thread.Sleep(1500);
                DateTime now = DateTime.Now;
                if (now.Second != this.Second)
                {
                    TimeInfoEventArgs timeInfoEventArgs = new TimeInfoEventArgs(now.Hour, now.Minute, now.Second);
                    OnTick(this, timeInfoEventArgs);
                }
            }
        }
    }

}
