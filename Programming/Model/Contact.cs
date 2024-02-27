using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Contact
    {
        string? _number;
        string? _adressName;
        string? _region;

        // string AdressName, any string values
        public string? AdressName { get; set; }
        // string Region, any string values
        public string? Region { get; set; }
        // string Number, string values with length in range between 0 and 18: [0, 18). In another cases - ArgumentException
        public string? Number
        {
            get
            {
                return _number;
            }
            set
            {
                if ((value == null) || (value.Length < 18))
                {
                    throw new ArgumentException("Number must be under 18 letter (more than 0)");
                }
                else
                {
                    _number = value;
                }
            }
        }

        // Base constructor without arguments
        public Contact()
        {
            Number = "+1234567890";
            AdressName = "UTC";
            Region = "UK/GB";
        }

        // Constructor with arguments
        public Contact(string? number, string? adressName, string? region)
        {
            Number = number;
            AdressName = adressName;
            Region = region;
        }
    }
}
