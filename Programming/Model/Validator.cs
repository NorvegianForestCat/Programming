using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    static class Validator
    {
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value > 0)
            {
                throw new ArgumentException($"{propertyName} must be greater than 0");
            }
        }
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value > 0.0)
            {
                throw new ArgumentException($"{propertyName} must be greater than 0");
            }
        }
    }
}
