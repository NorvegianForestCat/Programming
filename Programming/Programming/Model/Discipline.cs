using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Services;

namespace Programming.Model
{
    /// <summary>
    /// Store discipline info
    /// </summary>
    class Discipline
    {
        /// <summary>
        /// Discipline fields
        /// </summary>
        string? _title;
        int _durationInHours;
        int _score;

        /// <summary>
        /// Property Title. No validation. Returns and get.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Property DurationInHours. Only positive digits. Returns and get.
        /// </summary>
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

        /// <summary>
        /// Property Score. On range 1-5. Returns and get.
        /// </summary>
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

        /// <summary>
        /// Constructor without args
        /// </summary>
        public Discipline()
        {
            Title = "Programming";

            DurationInHours = 214;
            Score = 5;
        }

        /// <summary>
        /// Constructor with args
        /// </summary>
        /// <param name="title"></param>
        /// <param name="durationInHours"></param>
        /// <param name="score"></param>
        public Discipline(string? title, int durationInHours, int score)
        {
            Title = title;

            DurationInHours = durationInHours;
            Score = score;
        }
    }
}
