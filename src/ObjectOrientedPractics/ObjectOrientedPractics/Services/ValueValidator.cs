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
        /// Assertion string with length
        /// </summary>
        /// <param name="value">String</param>
        /// <param name="maxLength">Max length</param>
        /// <param name="propertyName">Property name</param>
        /// <exception cref="ArgumentException">Throw if not asserted</exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} must be less than {maxLength} symbols");
            }
        }

        /// <summary>
        /// Assertion doubles with value
        /// </summary>
        /// <param name="value">Number</param>
        /// <param name="maxLength">Max current</param>
        /// <param name="propertyName">Property name</param>
        /// <exception cref="ArgumentException">Throw if not asserted</exception>
        public static void AssertNumberOnLength(double value, double maxLength, string propertyName)
        {
            if(value > maxLength)
            {
                throw new ArgumentException($"{propertyName} must be less than {maxLength}");
            }
        }
    }
}
