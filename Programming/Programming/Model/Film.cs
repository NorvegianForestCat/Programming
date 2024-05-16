using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Services;

namespace Programming.Model
{
    /// <summary>
    /// Store film info
    /// </summary>
    class Film
    {
        /// <summary>
        /// Film fields
        /// </summary>
        string? _title;
        string? _genre;
        int _duration;
        int _releaseYear;
        double _rating;

        /// <summary>
        /// Property Title. Returns and get.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Property Genre. Returns and get.
        /// </summary>
        public string? Genre { get; set; }

        /// <summary>
        /// Property Duratiom. Returns and get.
        /// </summary>
        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Film.Duration");
                _duration = value;
            }
        }

        /// <summary>
        /// Property ReleaseYear. Returns and get.
        /// </summary>
        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, "Film.ReleaseYear");
                _releaseYear = value;
            }
        }

        /// <summary>
        /// Property Rating. Returns and get.
        /// </summary>
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 0.0, 10.0, "Film.Rating");
                _rating = value;
            }
        }

        /// <summary>
        /// Base constructor
        /// </summary>
        public Film()
        {
            Title = "Monty Python and the Holy Grail";
            Genre = "History, Comedy";

            Duration = 90;
            ReleaseYear = 1975;
            Rating = 7.8;
        }

        /// <summary>
        /// Constructor with args
        /// </summary>
        /// <param name="title"></param>
        /// <param name="genre"></param>
        /// <param name="duration"></param>
        /// <param name="releaseYear"></param>
        /// <param name="rating"></param>
        public Film(string? title, string? genre, int duration, int releaseYear, double rating)
        {
            Title = title;
            Genre = genre;

            Duration = duration;
            ReleaseYear = releaseYear;
            
            Rating = rating;
        }
    }
}
