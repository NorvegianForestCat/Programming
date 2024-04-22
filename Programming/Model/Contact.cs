using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Services;

namespace Programming.Model
{
    class Contact
    {
        string? _number;
        string? _name;
        string? _surname;
        string? _region;

        // string Name, only latin letters
        public string? Name 
        { 
            get => _name; 
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, "Name");
                _name = value;
            }
        }
        // string Surname, only latin letters
        public string? Surname 
        {
            get => _surname;
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, "Surname");
                _surname = value;
            }
        }
        // string Region, only latin letters
        public string? Region 
        {
            get => _region;
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, "Region");                
                _region = value;              
            }
        }
        // string Number, string values with length in range between 0 and 18: [0, 18). In another cases - ArgumentException
        public string? Number
        {
            get => _number;
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
            Name = "Fiodor";
            Surname = "Aikui";
            Region = "UK/GB";
        }

        // Constructor with arguments
        public Contact(string? number, string? name, string? surname, string? region)
        {
            Number = number;
            Name = name;
            Surname = surname;
            Region = region;
        }

        
    }
}
