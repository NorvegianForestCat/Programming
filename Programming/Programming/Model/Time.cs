using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Store time info
    /// </summary>
    class Time
    {
        int _hour;
        int _minute;
        int _second;

        /// <summary>
        /// Property Hour. In range 0 - 23. Returns and get.
        /// </summary>
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

        /// <summary>
        /// Property Minute. In range 0 - 59. Returns and get.
        /// </summary>
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

        /// <summary>
        /// Property Second. In range 0 - 59. Returns and get.
        /// </summary>
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

        /// <summary>
        /// Constructor without args
        /// </summary>
        public Time()
        {
            Second = 0;
            Minute = 0;
            Hour = 0;
        }

        /// <summary>
        /// Constructor with args
        /// </summary>
        /// <param name="second">int</param>
        /// <param name="hour">int</param>
        /// <param name="minute">int</param>
        public Time(int second, int hour, int minute)
        {
            Second = second;
            Minute = minute;
            Hour = hour;
        }
    }
}
