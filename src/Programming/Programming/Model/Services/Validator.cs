using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Services
{
    /// <summary>
    /// Provide validation functions
    /// </summary>
    static class Validator
    {
        /// <summary>
        /// Assertion on positive value
        /// </summary>
        /// <param name="value">Value</param>
        /// <param name="propertyName">Property name</param>
        /// <exception cref="ArgumentException">If assertion is not passed</exception>
        public static void AssertOnPositiveValue(int? value, string propertyName)
        {
            if (value == null) return;

            if (value < 0)
            {
                throw new ArgumentException($"{propertyName} must be greater than 0");
            }
        }

        /// <summary>
        /// Assertion on positive value
        /// </summary>
        /// <param name="value">Value</param>
        /// <param name="propertyName">Property name</param>
        /// <exception cref="ArgumentException">If assertion is not passed</exception>
        public static void AssertOnPositiveValue(double? value, string propertyName)
        {
            if (value == null) return;

            if (value < 0.0)
            {
                throw new ArgumentException($"{propertyName} must be greater than 0");
            }
        }

        /// <summary>
        /// Assertion on positive value in range
        /// </summary>
        /// <param name="value">Value</param>
        /// <param name="max">Max value</param>
        /// <param name="min">Min value</param>
        /// <param name="propertyName">Property name</param>
        /// <exception cref="ArgumentException">If assertion is not passed</exception>
        public static void AssertValueInRange(int? value, int min, int max, string propertyName)
        {
            if (value == null) return;

            if (value < min || value > max)
            {
                throw new ArgumentException($"{propertyName} must be in range between {min} and {max}");
            }
        }

        /// <summary>
        /// Assertion on positive value in range
        /// </summary>
        /// <param name="value">Value</param>
        /// <param name="max">Max value</param>
        /// <param name="min">Min value</param>
        /// <param name="propertyName">Property name</param>
        /// <exception cref="ArgumentException">If assertion is not passed</exception>
        public static void AssertValueInRange(double? value, double min, double max, string propertyName)
        {
            if (value == null) return;

            if (value < min || value >= max)
            {
                throw new ArgumentException($"{propertyName} must be in range between {min} and {max}");
            }
        }

        /// <summary>
        /// Assertion on contains latin letters only
        /// </summary>
        /// <param name="value">Value</param>
        /// <param name="propertyName">Property name</param>
        /// <exception cref="ArgumentException">If assertion is not passed</exception>
        public static void AssertStringContainsOnlyLetters(string? value, string propertyName)
        {
            if (value == null) return;

            foreach (char letter in value.ToUpper())
            {
                if (letter < 65 || letter > 90)
                {
                    throw new ArgumentException($"{propertyName} must consists of only latin letters");
                }
            }
        }
    }
}
