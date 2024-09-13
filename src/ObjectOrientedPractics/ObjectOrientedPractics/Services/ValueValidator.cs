using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    internal static class ValueValidator
    {
        public static void AssertStringOnLength(int value, int maxLength, string propertyName)
        {
            if (value > maxLength)
            {
                throw new ArgumentException($"{propertyName} must be less than {maxLength} symbols");
            }
        }
    }
}
