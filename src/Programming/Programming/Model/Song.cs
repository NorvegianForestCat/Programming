using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Services;

namespace Programming.Model
{
    /// <summary>
    /// Store song info
    /// </summary>
    class Song
    {
        int _durationInSeconds;
        string? _songName;
        string? _artistName;

        /// <summary>
        /// Property SongName. Returns and get.
        /// </summary>
        public string? SongName { get; set; }
        /// <summary>
        /// Property ArtistName. Returns and get.
        /// </summary>
        public string? ArtistName { get; set; }
        /// <summary>
        /// Property DurationInSeconds. Returns and get.
        /// </summary>
        public int DurationInSeconds
        {
            get 
            { 
                return _durationInSeconds; 
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Duration");
                _durationInSeconds = value;                
            }
        }

        /// <summary>
        /// Constructor without args
        /// </summary>
        public Song()
        {
            SongName = "Wind of Changes";
            ArtistName = "Scorpions";

            DurationInSeconds = 311;
        }

        /// <summary>
        /// Constructor with args
        /// </summary>
        /// <param name="songName">string</param>
        /// <param name="artistName">string</param>
        /// <param name="duration">int</param>
        public Song(string songName, string artistName, int duration)
        {
            SongName = songName;
            ArtistName = artistName;

            DurationInSeconds = duration;
        }
    }
}
