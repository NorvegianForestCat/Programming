using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InformationSystem.Model.Service;

namespace InformationSystem.Model
{
    /// <summary>
    /// Class that providing song model
    /// </summary>
    internal class Song
    {
        private string? _title;
        private string? _name;
        private int _duration;
        private Genre _genre;

        /// <summary>
        /// Gets or sets the string value that specifies
        /// which title song has.
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// Gets or sets the string value that specifies
        /// which name song`s artist has.
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="T:InformationSystem.Model.Genre"/> value that specifies
        /// which genre song has.
        /// </summary>
        public Genre Genre { get; set; }
        /// <summary>
        /// Gets or sets the int value that specifies
        /// which duration song has.
        /// </summary>
        /// <value>Duration must be positive number.</value>
        public int Duration
        {
            get => _duration;
            set
            {
                Validator.IsPositiveInt(value);
                _duration = value;
            }
        }

        /// <summary>
        /// Constructor without values
        /// </summary>      
        public Song()
        {
            Title = "Song title";
            Name = "Song name";
            Duration = 1234;
            Genre = Genre.Rock;
        }

        /// <summary>
        /// Constructor of class <see cref="Song"/>
        /// </summary>
        /// <param name="title">Song title</param>
        /// <param name="name">Artist name</param>
        /// <param name="duration">Song duration</param>
        /// <param name="genre">Song genre</param>
        public Song(string title, string name, int duration, Genre genre)
        {
            Title = title;
            Name = name;
            Duration = duration;
            Genre = genre;
        }

        /// <summary>
        /// Overrided <see cref="M:System.Object.ToString()"/>
        /// </summary>
        /// <returns>String representasion of song: [artist name] - [song title]</returns>
        public override string ToString()
        {
            return $"{Name} - {Title}";
        }
    }
}
