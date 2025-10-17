using Programming.Model.Services;

namespace Programming.Model
{
    /// <summary>
    /// Represents an academic discipline, including its title, duration in hours, and student score.
    /// </summary>
    public class Discipline
    {
        private string? _title;
        private int _durationInHours;
        private int _score;

        /// <summary>
        /// Gets or sets the title of the discipline.
        /// No validation is performed; can be <see langword="null"/> or empty.
        /// </summary>
        /// <value>The name of the discipline (e.g., "Programming", "Mathematics").</value>
        public string? Title
        {
            get => _title;
            set => _title = value;
        }

        /// <summary>
        /// Gets or sets the duration of the discipline in hours. Must be a positive integer.
        /// </summary>
        /// <value>An integer representing total hours. Must be greater than zero.</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is less than or equal to zero.
        /// </exception>
        public int DurationInHours
        {
            get => _durationInHours;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationInHours));
                _durationInHours = value;
            }
        }

        /// <summary>
        /// Gets or sets the student's score for the discipline. Valid range: 1 to 5 inclusive.
        /// </summary>
        /// <value>An integer from 1 (lowest) to 5 (highest). Represents academic performance.</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is less than 1 or greater than 5.
        /// </exception>
        public int Score
        {
            get => _score;
            set
            {
                // Проверяем диапазон: 1–5 (оценки)
                Validator.AssertValueInRange(value, 1, 6, nameof(Score)); // [1, 5] → min=1, max=6 (exclusive)
                _score = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Discipline"/> class with default values.
        /// </summary>
        public Discipline()
        {
            Title = "Programming";
            DurationInHours = 214;
            Score = 5;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Discipline"/> class with specified parameters.
        /// </summary>
        /// <param name="title">The title of the discipline. Can be <see langword="null"/> or empty.</param>
        /// <param name="durationInHours">The total duration in hours. Must be greater than zero.</param>
        /// <param name="score">The student's score. Must be between 1 and 5 inclusive.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="durationInHours"/> is not positive or <paramref name="score"/> is out of range.
        /// </exception>
        public Discipline(string? title, int durationInHours, int score)
        {
            Title = title;
            DurationInHours = durationInHours;
            Score = score;
        }

        /// <summary>
        /// Returns a string representation of the discipline in format: "Title (Duration hrs, Score/5)".
        /// </summary>
        /// <returns>A human-readable string describing the discipline.</returns>
        public override string ToString()
        {
            return $"{Title} ({DurationInHours} hrs, {Score}/5)";
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="Discipline"/> instance.
        /// </summary>
        /// <param name="obj">The object to compare with this instance.</param>
        /// <returns><see langword="true"/> if the objects are equal; otherwise, <see langword="false"/>.</returns>
        public override bool Equals(object? obj)
        {
            return obj is Discipline other &&
                   Title == other.Title &&
                   DurationInHours == other.DurationInHours &&
                   Score == other.Score;
        }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Title, DurationInHours, Score);
        }
    }
}