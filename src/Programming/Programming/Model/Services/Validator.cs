namespace Programming.Model.Services
{
    /// <summary>
    /// Provides a collection of static methods for validating common data constraints.
    /// All methods throw an <see cref="ArgumentException"/> if validation fails.
    /// Null values are typically ignored (treated as valid) unless otherwise specified.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Ensures the specified integer value is positive (greater than zero).
        /// A null value is considered valid and does not throw an exception.
        /// </summary>
        /// <param name="value">The nullable integer to validate.</param>
        /// <param name="parameterName">The name of the parameter being validated, used in error messages.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is not null and is less than or equal to zero.
        /// </exception>
        public static void AssertOnPositiveValue(int? value, string parameterName)
        {
            if (value.HasValue && value <= 0)
            {
                throw new ArgumentException($"{parameterName} must be greater than zero.", parameterName);
            }
        }

        /// <summary>
        /// Ensures the specified double value is positive (greater than zero).
        /// A null value is considered valid and does not throw an exception.
        /// </summary>
        /// <param name="value">The nullable double to validate.</param>
        /// <param name="parameterName">The name of the parameter being validated, used in error messages.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is not null and is less than or equal to zero.
        /// </exception>
        public static void AssertOnPositiveValue(double? value, string parameterName)
        {
            if (value.HasValue && value <= 0.0)
            {
                throw new ArgumentException($"{parameterName} must be greater than zero.", parameterName);
            }
        }

        /// <summary>
        /// Ensures the specified integer value is within the specified range (inclusive of min, exclusive of max).
        /// A null value is considered valid and does not throw an exception.
        /// </summary>
        /// <param name="value">The nullable integer to validate.</param>
        /// <param name="min">The minimum allowed value (inclusive).</param>
        /// <param name="max">The maximum allowed value (exclusive).</param>
        /// <param name="parameterName">The name of the parameter being validated.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is not null and is outside the specified range.
        /// </exception>
        public static void AssertValueInRange(int? value, int min, int max, string parameterName)
        {
            if (!value.HasValue) return;

            if (value < min || value >= max)
            {
                throw new ArgumentException(
                    $"{parameterName} must be in the range [{min}, {max}). Received: {value}.",
                    parameterName);
            }
        }

        /// <summary>
        /// Ensures the specified double value is within the specified range (inclusive of min, exclusive of max).
        /// A null value is considered valid and does not throw an exception.
        /// </summary>
        /// <param name="value">The nullable double to validate.</param>
        /// <param name="min">The minimum allowed value (inclusive).</param>
        /// <param name="max">The maximum allowed value (exclusive).</param>
        /// <param name="parameterName">The name of the parameter being validated.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is not null and is outside the specified range.
        /// </exception>
        public static void AssertValueInRange(double? value, double min, double max, string parameterName)
        {
            if (!value.HasValue) return;

            if (value < min || value >= max)
            {
                throw new ArgumentException(
                    $"{parameterName} must be in the range [{min}, {max}). Received: {value:F2}.",
                    parameterName);
            }
        }

        /// <summary>
        /// Ensures the specified string contains only Latin letters (A–Z, a–z).
        /// A null or empty string is considered valid.
        /// </summary>
        /// <param name="value">The string to validate.</param>
        /// <param name="parameterName">The name of the parameter being validated, used in error messages.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when the string is not null and contains non-letter or non-Latin characters.
        /// </exception>
        public static void AssertStringContainsOnlyLetters(string? value, string parameterName)
        {
            if (string.IsNullOrEmpty(value)) return;

            if (!value.All(c => char.IsLetter(c) && ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))))
            {
                throw new ArgumentException(
                    $"{parameterName} must contain only Latin letters (A–Z, a–z). Found invalid character(s).",
                    parameterName);
            }
        }
    }
}