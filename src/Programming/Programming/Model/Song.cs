using Programming.Model.Services;

namespace Programming.Model
{
    /// <summary>
    /// Represents a musical track with title, artist, and duration.
    /// </summary>
    public class Song : IEquatable<Song>
    {
        private string? _songName;
        private string? _artistName;
        private int _durationInSeconds;

        /// <summary>
        /// Gets or sets the name of the song.
        /// Can be <see langword="null"/> or empty.
        /// </summary>
        /// <value>The title of the track (e.g., "Wind of Changes").</value>
        public string? SongName
        {
            get => _songName;
            set => _songName = value;
        }

        /// <summary>
        /// Gets or sets the name of the artist or band.
        /// Can be <see langword="null"/> or empty.
        /// </summary>
        /// <value>The performer's name (e.g., "Scorpions").</value>
        public string? ArtistName
        {
            get => _artistName;
            set => _artistName = value;
        }

        /// <summary>
        /// Gets or sets the duration of the song in seconds. Must be a positive integer.
        /// </summary>
        /// <value>An integer representing the length of the song in seconds (e.g., 311).</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is less than or equal to zero.
        /// </exception>
        public int DurationInSeconds
        {
            get => _durationInSeconds;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationInSeconds));
                _durationInSeconds = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Song"/> class with default values.
        /// </summary>
        public Song()
        {
            SongName = "Wind of Changes";
            ArtistName = "Scorpions";
            DurationInSeconds = 311;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Song"/> class with specified parameters.
        /// </summary>
        /// <param name="songName">The title of the song. Can be <see langword="null"/>.</param>
        /// <param name="artistName">The name of the artist or band. Can be <see langword="null"/>.</param>
        /// <param name="duration">The duration of the song in seconds. Must be greater than zero.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="duration"/> is not a positive value.
        /// </exception>
        public Song(string? songName, string? artistName, int duration)
        {
            SongName = songName;
            ArtistName = artistName;
            DurationInSeconds = duration;
        }

        /// <summary>
        /// Returns a string representation of the song in format: "SongName — ArtistName (MM:SS)".
        /// </summary>
        /// <returns>A human-readable string describing the song and its duration in minutes and seconds.</returns>
        public override string ToString()
        {
            int minutes = _durationInSeconds / 60;
            int seconds = _durationInSeconds % 60;
            return $"{SongName} — {ArtistName} ({minutes:D1}:{seconds:D2})";
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
        /// <see langword="true"/> if both songs have identical name, artist, and duration; otherwise, <see langword="false"/>.
        /// </returns>
        public bool Equals(Song? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return SongName == other.SongName &&
                   ArtistName == other.ArtistName &&
                   DurationInSeconds == other.DurationInSeconds;
        }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(SongName, ArtistName, DurationInSeconds);
        }
    }
}