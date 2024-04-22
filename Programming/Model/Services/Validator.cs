using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Services
{
    static class Validator
    {
        // Assertion for positive int values
        public static void AssertOnPositiveValue(int? value, string propertyName)
        {
            if (value == null) return;

            if (value < 0)
            {
                throw new ArgumentException($"{propertyName} must be greater than 0");
            }
        }

        // Assertion for positive double values
        public static void AssertOnPositiveValue(double? value, string propertyName)
        {
            if (value == null) return;

            if (value < 0.0)
            {
                throw new ArgumentException($"{propertyName} must be greater than 0");
            }
        }

        // Assertion for in-range int values
        public static void AssertValueInRange(int? value, int min, int max, string propertyName)
        {
            if (value == null) return;

            if (value < min || value > max)
            {
                throw new ArgumentException($"{propertyName} must be in range between {min} and {max}");
            }
        }

        // Assertion for in-range double values
        public static void AssertValueInRange(double? value, double min, double max, string propertyName)
        {
            if (value == null) return;

            if (value < min || value >= max)
            {
                throw new ArgumentException($"{propertyName} must be in range between {min} and {max}");
            }
        }

        // Check string for consists of only latin letters
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
