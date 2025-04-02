namespace View.Model
{
    /// <summary>
    /// Class for containing contact info.
    /// </summary>
    /// <remarks>
    /// Class has name, phone number and e-mail info.
    /// </remarks>
    class Contact
    {
        /// <summary>
        /// String field storing contact name
        /// </summary>
        private string _name;
        /// <summary>
        /// String field storing contact phone number
        /// </summary>
        private string _phoneNumber;
        /// <summary>
        /// String field storing contact e-mail
        /// </summary>
        private string _email;

        /// <summary>
        /// Contact name.
        /// Gets contact name as a not-null-string, returns contact 
        /// name as a string.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if(value == null)
                {
                    throw new ArgumentException($"{value} is not valid value");
                }

                _name = value;
            }
        }
        /// <summary>
        /// Contact phone number
        /// Gets contact phone number as a not-null-string, returns contact 
        /// phone number as a string.
        /// </summary>
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (value == null)
                {
                    throw new ArgumentException($"{value} is not valid value");
                }

                _phoneNumber = value;
            }
        }
        /// <summary>
        /// Contact e-email
        /// Gets contact e-mail as a not-null-string, returns contact e-mail 
        /// as a string.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                if (value == null)
                {
                    throw new ArgumentException($"{value} is not valid value");
                }

                _email = value;
            }
        }

        /// <summary>
        /// Initialize new <see cref="Contact"/> instance without parameters.
        /// </summary>
        public Contact()
        {
            Name = "base";
            PhoneNumber = "+0123456789";
            Email = "email@email.com";
        }
        /// <summary>
        /// Initialize new <see cref="Contact"/> instance with parameters.
        /// </summary>
        /// <param name="name">
        /// Contact name
        /// </param>
        /// <param name="phoneNumber">
        /// Contact phone number
        /// </param>
        /// <param name="email">
        /// Contact e-mailS
        /// </param>
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
