using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Contact
    {
        string? number;
        string? adressName;
        string? region;

        public string? AdressName { get; set; }
        public string? Region { get; set; }
        public string? Number
        {
            get
            {
                return number;
            }
            set
            {
                if ((value == null) || (value.Length < 18))
                {
                    throw new ArgumentException("Number must be under 18 letter (more than 0)");
                }
                else
                {
                    number = value;
                }
            }
        }
        public Contact()
        {
            Number = "+1234567890";
            AdressName = "UTC";
            Region = "UK/GB";
        }

        public Contact(string? number, string? adressName, string? region)
        {
            Number = number;
            AdressName = adressName;
            Region = region;
        }
    }
}
