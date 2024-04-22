using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Services;

namespace Programming.Model
{
    class Discipline
    {
        string? 
            
            
            
            
  _title;
        int _durationInHours;
        int _score;

        // string Title, any string value
        public string? Title { get; set; }

        // int DurationInHours, int value above 0. In another cases - ArgumentException
        public int DurationInHours 
        { 
            get 
            {
                return _durationInHours;

            } 
            set
            {
                Validator.AssertOnPositiveValue(value, "Duration");
                _durationInHours = value;
            }
        }

        // int Score, int value in range between 0 and 5: [0, 5]. In another cases - ArgumentException
        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 6, "Discipline.Score");
                _score = value;
            }
        }

        // Base constructor without arguments
        public Discipline()
        {
            Title = "Programming";

            DurationInHours = 214;
            Score = 5;
        }

        // Constructor with arguments
        public Discipline(string? title, int durationInHours, int score)
        {
            Title = title;

            DurationInHours = durationInHours;
            Score = score;
        }
    }
}
