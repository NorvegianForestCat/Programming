using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Time
    {
        int _hour;
        int _minute;
        int _second;

        // int Hour, int value in range between 0 and 24: [0, 24). In another cases - ArgumentException
        public int Hour
        {
            get
            {
                return _hour; 
            } 
            set
            {
                if(value >= 0 && value < 24)
                {
                    _hour = value;
                }
                else
                {
                    throw new ArgumentException("Number of hours must be in interval 0-23");
                }
            }
        }

        // int Minute, int value in range between 0 and 60: [0, 60). In another cases - ArgumentException
        public int Minute
        {
            get
            {
                return _minute;
            }
            set
            {
                if (value >= 0 && value < 60)
                {
                    _minute = value;
                }
                else
                {
                    throw new ArgumentException("Number of minutes must be in interval 0-59");
                }
            }
        }

        // int Second, int value in range between 0 and 60: [0, 60). In another cases - ArgumentException
        public int Second
        {
            get
            {
                return _second;
            }
            set
            {
                if (value >= 0 && value < 60)
                {
                    _second = value;
                }
                else
                {
                    throw new ArgumentException("Number of seconds must be in interval 0-59");
                }
            }
        }

        // Base constructor without arguments
        public Time()
        {
            Second = 0;
            Minute = 0;
            Hour = 0;
        }

        // Constructor with arguments
        public Time(int second, int hour, int minute)
        {
            Second = second;
            Minute = minute;
            Hour = hour;
        }
    }
}
