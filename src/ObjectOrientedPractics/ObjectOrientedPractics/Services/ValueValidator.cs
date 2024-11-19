using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Static service class calidating values
    /// </summary>
    internal static class ValueValidator
    {
        /// <summary>
        /// Check string length
        /// </summary>
        /// <param name="value">Value</param>
        /// <param name="maxLength">Max length</param>
        /// <param name="propertyName">Property name</param>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new
                    ArgumentException($"{propertyName} must be less than {maxLength} syms");
            }
        }

        /// <summary>
        /// Check double value
        /// </summary>
        /// <param name="value">Value</param>
        /// <param name="minimum">Minimum</param>
        /// <param name="maximum">Maximum</param>
        /// <param name="propertyName">Property name</param>
        public static void AssertDoubleOnLimits(double value, double minimum,
            double maximum, string propertyName)
        {
            if (value < minimum || value > maximum)
            {
                throw new
                    ArgumentException(
                    $"{propertyName} not in range from {minimum} to {maximum}.");
            }
        }

        /// <summary>
        /// Check value data
        /// </summary>
        /// <param name="value">Value</param>
        /// <param name="digit">Number of digits</param>
        /// <param name="propertyName">Property name</param>
        public static void AssertIntOnDigit(int value, int digit, string propertyName)
        {
            if (value.ToString().Length != digit)
            {
                throw new
                    ArgumentException(
                    $"{propertyName} must consists of {digit} digits");
            }
        }

    }
}
