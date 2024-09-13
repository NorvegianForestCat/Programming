using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    internal static class ValueValidator
    {
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} must be less than {maxLength} symbols");
            }
        }

        public static void AssertNumberOnLength(double value, double maxLength, string propertyName)
        {
            if(value > maxLength)
            {
                throw new ArgumentException($"{propertyName} must be less than {maxLength}");
            }
        }
    }
}
