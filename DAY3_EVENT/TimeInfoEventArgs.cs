using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAY3_EVENT
{
    public class TimeInfoEventArgs:EventArgs
    {
        public readonly int Hour ;
        public readonly int Minute ;
        public readonly int Second ;

        public TimeInfoEventArgs(int hour, int minute, int second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }

    }
}