using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystem.Model.Service
{
    /// <summary>
    /// Static class that providing validation functions for userdata
    /// </summary>
    static class Validator
    {
        /// <summary>
        /// Check if value is positive
        /// </summary>
        /// <param name="value">Checked value</param>
        /// <exception cref="ArgumentException">throw if value less than 0</exception>
        public static void IsPositiveInt(int? value)
        {
            if (value == null) return;

            if (value < 0) throw new ArgumentException("Value must be positive");
        }

        /// <summary>
        /// Check if string correct
        /// </summary>
        /// <param name="value">Checked string</param>
        /// <exception cref="ArgumentException">throw if string greater than 50 symbols</exception>
        public static void IsValidString(string? value)
        {
            if (value == null) return;

            if (value.Length > 50) throw new ArgumentException("String must be shorter than 50 symbols");
        }

        /// <summary>
        /// Check if number less than some threshold
        /// </summary>
        /// <param name="value">Checked value</param>
        /// <param name="threshold">Threshold</param>
        /// <exception cref="ArgumentException">throw if number greater than threshold</exception>
        public static void IsLessThan(int? value, int threshold)
        {
            if (value == null) return;

            if (value > threshold) throw new ArgumentException($"Value must be less than {threshold}");
        }
    }
}
