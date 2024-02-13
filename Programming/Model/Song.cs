using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Song
    {
        int durationInSeconds;

        string? songName;
        string? artistName;

        public string? SongName { get; set; }
        public string? ArtistName { get; set; }
        public int DurationInSeconds
        {
            get 
            { 
                return durationInSeconds; 
            }
            set
            {
                if(value > 0)
                {
                    durationInSeconds = value;
                }
                else
                {
                    throw new ArgumentException("Duration must be more than 0 seconds");
                }
            }
        }

        public Song()
        {
            SongName = "Wind of Changes";
            ArtistName = "Scorpions";

            DurationInSeconds = 311;
        }

        public Song(string songName, string artistName, int duration)
        {
            SongName = songName;
            ArtistName = artistName;

            DurationInSeconds = duration;
        }
    }
}
