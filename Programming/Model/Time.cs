using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Time
    {
        int hour;
        int minute;
        int second;

        public int Hour
        {
            get
            {
                return hour; 
            } 
            set
            {
                if(value >= 0 && value < 24)
                {
                    hour = value;
                }
                else
                {
                    throw new ArgumentException("Number of hours must be in interval 0-23");
                }
            }
        }

        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                if (value >= 0 && value < 60)
                {
                    minute = value;
                }
                else
                {
                    throw new ArgumentException("Number of minutes must be in interval 0-59");
                }
            }
        }
        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                if (value >= 0 && value < 60)
                {
                    second = value;
                }
                else
                {
                    throw new ArgumentException("Number of seconds must be in interval 0-59");
                }
            }
        }

        public Time()
        {
            Second = 0;
            Minute = 0;
            Hour = 0;
        }

        public Time(int second, int hour, int minute)
        {
            Second = second;
            Minute = minute;
            Hour = hour;
        }
    }
}
