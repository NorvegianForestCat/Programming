using Programming.Model.Services;

namespace Programming.Model
{
    /// <summary>
    /// Represents a film with title, genre, duration, release year, and rating.
    /// </summary>
    public class Film : IEquatable<Film>
    {
        private string? _title;
        private Genre _genre;
        private int _duration;
        private int _releaseYear;
        private double _rating;

        /// <summary>
        /// Gets or sets the title of the film.
        /// Can be <see langword="null"/> or empty.
        /// </summary>
        /// <value>The name of the film (e.g., "Monty Python and the Holy Grail").</value>
        public string? Title
        {
            get => _title;
            set => _title = value;
        }

        /// <summary>
        /// Gets or sets the genre of the film.
        /// Must be one of the predefined values in the <see cref="Genre"/> enumeration.
        /// </summary>
        /// <value>The genre category of the film.</value>
        public Genre Genre
        {
            get => _genre;
            set => _genre = value;
        }

        /// <summary>
        /// Gets or sets the duration of the film in minutes. Must be a positive integer.
        /// </summary>
        /// <value>An integer representing the length of the film in minutes.</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is less than or equal to zero.
        /// </exception>
        public int Duration
        {
            get => _duration;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Duration));
                _duration = value;
            }
        }

        /// <summary>
        /// Gets or sets the release year of the film. Must be between 1900 and the current year.
        /// </summary>
        /// <value>An integer representing the year the film was released.</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is outside the valid range (1900–current year).
        /// </exception>
        public int ReleaseYear
        {
            get => _releaseYear;
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year + 1, nameof(ReleaseYear));
                _releaseYear = value;
            }
        }

        /// <summary>
        /// Gets or sets the rating of the film. Typically on a 0–10 scale.
        /// </summary>
        /// <value>A double representing the film's rating (e.g., 7.8).</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is less than 0.0 or greater than 10.0.
        /// </exception>
        public double Rating
        {
            get => _rating;
            set
            {
                Validator.AssertValueInRange(value, 0.0, 10.0, nameof(Rating));
                _rating = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Film"/> class with default values.
        /// </summary>
        public Film()
        {
            Title = "Monty Python and the Holy Grail";
            Genre = Genre.Comedy;
            Duration = 90;
            ReleaseYear = 1975;
            Rating = 7.8;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Film"/> class with specified parameters.
        /// </summary>
        /// <param name="title">The title of the film. Can be <see langword="null"/>.</param>
        /// <param name="genre">The genre of the film. Must be a valid <see cref="Genre"/> value.</param>
        /// <param name="duration">The duration in minutes. Must be greater than zero.</param>
        /// <param name="releaseYear">The year the film was released. Must be between 1900 and current year.</param>
        /// <param name="rating">The film's rating. Must be between 0.0 and 10.0 inclusive.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="duration"/>, <paramref name="releaseYear"/>, or <paramref name="rating"/> 
        /// are outside their valid ranges.
        /// </exception>
        public Film(string? title, Genre genre, int duration, int releaseYear, double rating)
        {
            Title = title;
            Genre = genre;
            Duration = duration;
            ReleaseYear = releaseYear;
            Rating = rating;
        }

        /// <summary>
        /// Returns a string representation of the film in format: "Title (Genre, Year) - Rating/10".
        /// </summary>
        /// <returns>A human-readable string describing the film.</returns>
        public override string ToString()
        {
            return $"{Title} ({Genre}, {ReleaseYear}) - {Rating:F1}/10";
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="Film"/> instance.
        /// </summary>
        /// <param name="obj">The object to compare with this instance.</param>
        /// <returns><see langword="true"/> if the objects are equal; otherwise, <see langword="false"/>.</returns>
        public override bool Equals(object? obj) => Equals(obj as Film);

        /// <summary>
        /// Determines whether the specified <see cref="Film"/> is equal to the current instance.
        /// </summary>
        /// <param name="other">The <see cref="Film"/> to compare with this instance.</param>
        /// <returns>
        /// <see langword="true"/> if both films have identical Title, Genre, Duration, ReleaseYear, and Rating; otherwise, <see langword="false"/>.
        /// </returns>
        public bool Equals(Film? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return Title == other.Title &&
                   Genre == other.Genre &&
                   Duration == other.Duration &&
                   ReleaseYear == other.ReleaseYear &&
                   Math.Abs(Rating - other.Rating) < 1e-6; // Для double
        }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Genre, Duration, ReleaseYear, Rating);
        }
    }
}