using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Services;

namespace Programming.Model
{
    /// <summary>
    /// Class consict of contact info
    /// </summary>
    class Contact
    {
        /// <summary>
        /// Fields of contact
        /// </summary>
        string? _number;
        string? _name;
        string? _surname;
        string? _region;

        /// <summary>
        /// Property Name. Consist only Latin. Returns and get.
        /// </summary>
        public string? Name 
        { 
            get => _name; 
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, "Name");
                _name = value;
            }
        }

        /// <summary>
        /// Property Surname. Consist only latin. Returns and get.
        /// </summary>
        public string? Surname 
        {
            get => _surname;
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, "Surname");
                _surname = value;
            }
        }

        /// <summary>
        /// Property Region. Consist only latin. Returns and get.
        /// </summary>
        public string? Region 
        {
            get => _region;
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, "Region");                
                _region = value;              
            }
        }

        /// <summary>
        /// Property Number. In range 1-17. Returns and get.
        /// </summary>
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

        /// <summary>
        /// Constructor without args
        /// </summary>
        public Contact()
        {
            Number = "+1234567890";
            Name = "Fiodor";
            Surname = "Aikui";
            Region = "UK/GB";
        }

        /// <summary>
        /// Constructor with args
        /// </summary>
        /// <param name="number"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="region"></param>
        public Contact(string? number, string? name, string? surname, string? region)
        {
            Number = number;
            Name = name;
            Surname = surname;
            Region = region;
        }

        
    }
}
