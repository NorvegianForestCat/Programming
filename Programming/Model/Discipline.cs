using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Discipline
    {
        string? title;

        int durationInHours;
        int score;

        public string? Title { get; set; }

        public int DurationInHours 
        { 
            get 
            {
                return durationInHours;

            } 
            set 
            {
                if(value > 0)
                {
                    durationInHours = value;
                }
                else
                {
                    throw new ArgumentException("Duration must be more than 0 hours");
                }
            }
        }
        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                if (value > 0 && value < 6)
                {
                    score = value;
                }
                else
                {
                    throw new ArgumentException("Score must be in interval behind 1 and 5");
                }
            }
        }

        public Discipline()
        {
            Title = "Programming";

            DurationInHours = 214;
            Score = 5;
        }

        public Discipline(string? title, int durationInHours, int score)
        {
            Title = title;

            DurationInHours = durationInHours;
            Score = score;
        }
    }
}
