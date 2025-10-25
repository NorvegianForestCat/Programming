namespace InformationSystem.Model.Service
{
    /// <summary>
    /// Provides a collection of static methods for validating common data constraints.
    /// All methods throw an <see cref="ArgumentException"/> if validation fails.
    /// Null values are typically treated as valid and do not trigger exceptions.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Ensures the specified integer value is positive (greater than zero).
        /// A null value is considered valid.
        /// </summary>
        /// <param name="value">The nullable integer to validate.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is not null and is less than or equal to zero.
        /// </exception>
        public static void IsPositiveInt(int? value)
        {
            if (value.HasValue && value <= 0)
            {
                throw new ArgumentException("Value must be greater than zero.", nameof(value));
            }
        }

        /// <summary>
        /// Ensures the specified string is not longer than 50 characters.
        /// A null or empty string is considered valid.
        /// </summary>
        /// <param name="value">The string to validate.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when the string is not null and exceeds 50 characters in length.
        /// </exception>
        public static void IsValidString(string? value)
        {
            if (value != null && value.Length > 50)
            {
                throw new ArgumentException("String must be 50 characters or fewer.", nameof(value));
            }
        }

        /// <summary>
        /// Ensures the specified integer value is less than the given threshold.
        /// A null value is considered valid.
        /// </summary>
        /// <param name="value">The nullable integer to validate.</param>
        /// <param name="threshold">The upper limit (exclusive).</param>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is not null and is greater than or equal to the threshold.
        /// </exception>
        public static void IsLessThan(int? value, int threshold)
        {
            if (value.HasValue && value >= threshold)
            {
                throw new ArgumentException($"Value must be less than {threshold}.", nameof(value));
            }
        }
    }
}