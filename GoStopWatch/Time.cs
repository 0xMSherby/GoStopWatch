using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoStopWatch
{
    public class Time
    {
        private int _seconds;
        private int _minutes;
        private int _hours;

        public int Seconds { get { return _seconds; } set { if (value >= 60) { this.Minutes++; _seconds = 0; } else { _seconds = value; } } }
        public int Minutes { get { return _minutes; } set { if (value >= 60) { this.Hours++; _minutes = 0; } else { _minutes = value; } } }
        public int Hours { get; set; }
        public string StringTime
        {
            get
            {
                return (Hours.ToString().Length == 1 ? "0" + Hours.ToString() : Hours.ToString())
                    + ":" + (Minutes.ToString().Length == 1 ? "0" + Minutes.ToString() : Minutes.ToString())
                    + ":" + (Seconds.ToString().Length == 1 ? "0" + Seconds.ToString() : Seconds.ToString());
            }
        }

        public void Reset()
        {
            this.Seconds = 0;
            this.Minutes = 0;
            this.Hours = 0;
        }
    }
}
