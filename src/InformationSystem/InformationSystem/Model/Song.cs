using InformationSystem.Model.Service;

namespace InformationSystem.Model
{
    /// <summary>
    /// Represents a musical track with title, artist, genre, and duration.
    /// </summary>  
    internal class Song : IEquatable<Song>
    {
        private int _duration;

        /// <summary>
        /// Gets or sets the title of the song.
        /// Can be <see langword="null"/> or empty.
        /// </summary>
        /// <value>The name of the track (e.g., "Bohemian Rhapsody").</value>
        public string? Title { get; set; }

        /// <summary>
        /// Gets or sets the name of the artist or band.
        /// Can be <see langword="null"/> or empty.
        /// </summary>
        /// <value>The performer's name (e.g., "Queen").</value>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the genre of the song.
        /// Must be one of the predefined values in the <see cref="Genre"/> enumeration.
        /// </summary>
        /// <value>The musical category of the song.</value>
        public Genre Genre { get; set; }

        /// <summary>
        /// Gets or sets the duration of the song in seconds. Must be a positive integer.
        /// </summary>
        /// <value>An integer representing the length of the song in seconds (e.g., 354).</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is less than or equal to zero.
        /// </exception>
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
        /// Initializes a new instance of the <see cref="Song"/> class with default values.
        /// </summary>
        public Song()
        {
            Title = "Song title";
            Name = "Song name";
            Duration = 1234;
            Genre = Genre.Rock;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Song"/> class with specified parameters.
        /// </summary>
        /// <param name="title">The title of the song. Can be <see langword="null"/>.</param>
        /// <param name="name">The name of the artist or band. Can be <see langword="null"/>.</param>
        /// <param name="duration">The duration of the song in seconds. Must be greater than zero.</param>
        /// <param name="genre">The genre of the song.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="duration"/> is not a positive value.
        /// </exception>
        public Song(string? title, string? name, int duration, Genre genre)
        {
            Title = title;
            Name = name;
            Duration = duration;
            Genre = genre;
        }

        /// <summary>
        /// Returns a string representation of the song in format: "Artist - Title".
        /// </summary>
        /// <returns>A human-readable string describing the song.</returns>
        public override string ToString()
        {
            return $"{Name} - {Title}";
        }
        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="Song"/> instance.
        /// </summary>
        /// <param name="obj">The object to compare with this instance.</param>
        /// <returns><see langword="true"/> if the objects are equal; otherwise, <see langword="false"/>.</returns>
        public override bool Equals(object? obj) => Equals(obj as Song);

        /// <summary>
        /// Determines whether the specified <see cref="Song"/> is equal to the current instance.
        /// </summary>
        /// <param name="other">The <see cref="Song"/> to compare with this instance.</param>
        /// <returns>
        /// <see langword="true"/> if both songs have identical title, artist, genre, and duration; otherwise, <see langword="false"/>.
        /// </returns>
        
        public bool Equals(Song? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return Title == other.Title &&
                   Name == other.Name &&
                   Genre == other.Genre &&
                   Duration == other.Duration;
        }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Name, Genre, Duration);
        }
    }
}
