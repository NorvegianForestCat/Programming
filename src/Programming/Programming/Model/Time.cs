namespace Programming.Model
{
    /// <summary>
    /// Represents a time of day, with hour, minute, and second components.
    /// Values are validated to be within standard ranges: 0–23 for hours, 0–59 for minutes and seconds.
    /// </summary>
    class Time
    {
        int _hour;
        int _minute;
        int _second;

        /// <summary>
        /// Gets or sets the hour component. Valid range: 0 to 23.
        /// </summary>
        /// <value>An integer representing the hour of the day.</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is less than 0 or greater than or equal to 24.
        /// </exception>
        public int Hour
        {
            get => _hour; 
            set
            {
                if(value is < 0 or >= 24)
                    throw new ArgumentException("Number of hours must be in interval 0-23");

                _hour = value;
            }
        }

        /// <summary>
        /// Gets or sets the minute component. Valid range: 0 to 59.
        /// </summary>
        /// <value>An integer representing the minute within the hour.</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is less than 0 or greater than or equal to 60.
        /// </exception>
        public int Minute
        {
            get => _minute;
            set
            {
                if (value is < 0 or >= 60)
                    throw new ArgumentException("Number of minutes must be in interval 0-59");

                _minute = value;
            }
        }

        /// <summary>
        /// Gets or sets the second component. Valid range: 0 to 59.
        /// </summary>
        /// <value>An integer representing the second within the minute.</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is less than 0 or greater than or equal to 60.
        /// </exception>
        public int Second
        {
            get => _second;
            set
            {
                if (value is < 0 or >= 60)
                    throw new ArgumentException("Number of seconds must be in interval 0-59");

                _second = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Time"/> class with default values (00:00:00).
        /// </summary>
        public Time()
        {
            Second = 0;
            Minute = 0;
            Hour = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Time"/> class with specified hour, minute, and second.
        /// </summary>
        /// <param name="hour">The hour component (0–23).</param>
        /// <param name="minute">The minute component (0–59).</param>
        /// <param name="second">The second component (0–59).</param>
        /// <exception cref="ArgumentException">
        /// Thrown when any parameter is outside its valid range.
        /// </exception>
        public Time(int second, int hour, int minute)
        {
            Second = second;
            Minute = minute;
            Hour = hour;
        }

        /// <summary>
        /// Returns a string representation of the time in HH:mm:ss format.
        /// </summary>
        /// <returns>A string in the format "HH:mm:ss", e.g., "14:35:07".</returns>
        public override string ToString()
        {
            return $"{Hour:D2}:{Minute:D2}:{Second:D2}";
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="Time"/> instance.
        /// </summary>
        /// <param name="obj">The object to compare with the current instance.</param>
        /// <returns><see langword="true"/> if the objects are equal; otherwise, <see langword="false"/>.</returns>
        public override bool Equals(object? obj)
        {
            return obj is Time other &&
                   Hour == other.Hour &&
                   Minute == other.Minute &&
                   Second == other.Second;
        }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Hour, Minute, Second);
        }
    }
}
