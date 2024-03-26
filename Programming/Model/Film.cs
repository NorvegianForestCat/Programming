using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Film
    {
        string? _title;
        string? _genre;
        int _duration;
        int _releaseYear;
        double _rating;

        // string Title, any string values
        public string? Title { get; set; }
        //string Genre, amy string values
        public string? Genre { get; set; }
        // int Duration, int value above 0. In another cases - ArgumentException
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
        // int ReleaseYear, int value in range between 1900 and this year: [1900, this year]. In another cases - ArgumentException
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
        // // double rating, double value in range between 0.0 and 10.0: [0.0, 10.0]. In another cases - ArgumentException
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

        // Base constructor without arguments
        public Film()
        {
            Title = "Monty Python and the Holy Grail";
            Genre = "History, Comedy";

            Duration = 90;
            ReleaseYear = 1975;
            Rating = 7.8;
        }

        // Constructor with arguments
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
