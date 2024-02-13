using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Film
    {
        string? title;
        string? genre;

        int duration;
        int releaseYear;

        double rating;

        public string? Title { get; set; }

        public string? Genre { get; set; }

        public int Duration
        {
            get
            {
                return duration;
            }
            set
            {
                if (value > 0)
                {
                    duration = value;
                }
                else
                {
                    throw new ArgumentException("Duration must be greater than 0");
                }
            }
        }
        public int ReleaseYear
        {
            get
            {
                return releaseYear;
            }
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year)
                {
                    releaseYear = value;
                }
                else
                {
                    throw new ArgumentException("Release year be greater than 1900 and less than present year");
                }
            }
        }

        public double Rating
        {
            get
            {
                return rating;
            }
            set
            {
                if (value > 0 && value <= 10)
                {
                    rating = value;
                }
                else
                {
                    throw new ArgumentException("Rating must be in interval 0-10");
                }
            }
        }

        public Film()
        {
            Title = "Monty Python and the Holy Grail";
            Genre = "History, Comedy";

            Duration = 90;
            ReleaseYear = 1975;
            Rating = 7.8;
        }


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
