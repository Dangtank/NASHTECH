using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAY3_EVENT
{
    public class DisplayClock
    {
        public void ShowClock(object clock, TimeInfoEventArgs timeInfoEvent)
        {
            Console.WriteLine($"{timeInfoEvent.Hour}:{timeInfoEvent.Minute}:{timeInfoEvent.Second}");
        }
        public void Subcribe(Clock clock)
        {
            //Subcribe an envent
            clock.clockTickEvent += new Clock.clockTick(ShowClock);
        }
        
    }
}