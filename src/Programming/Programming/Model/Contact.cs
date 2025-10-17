using Programming.Model.Services;

namespace Programming.Model
{
    /// <summary>
    /// Represents contact information, including name, surname, region, and phone number.
    /// </summary>
    class Contact
    {
        string? _number;
        string? _name;
        string? _surname;
        string? _region;

        /// <summary>
        /// Gets or sets the contact's first name. Must contain only Latin letters.
        /// </summary>
        /// <value>The first name as a string. Can be <see langword="null"/>.</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the value contains characters other than Latin letters.
        /// </exception>
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
        /// Gets or sets the contact's last name. Must contain only Latin letters.
        /// </summary>
        /// <value>The surname as a string. Can be <see langword="null"/>.</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the value contains characters other than Latin letters.
        /// </exception>
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
        /// Gets or sets the contact's region. Must contain only Latin letters.
        /// </summary>
        /// <value>The region name (e.g., "UK", "US"). Can be <see langword="null"/>.</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the value contains characters other than Latin letters.
        /// </exception>
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
        /// Gets or sets the contact's number. Must be at least 18 characters long and not null.
        /// </summary>
        /// <value>A string representing the number (e.g., starting with '+'). Must not be null and must have length ≥ 18.</value>
        /// <exception cref="ArgumentNullException">Thrown when the value is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentException">Thrown when the length of the value is less than 18 characters.</exception>
        public string? Number
        {
            get => _number;
            set
            {
                if ((value == null) || (value.Length < 18))
                {
                    throw new ArgumentException("Number must be at least 18 characters long.");
                }
                else
                {
                    _number = value;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class with default values.
        /// </summary>
        public Contact()
        {
            Number = "+012345678910111213";
            Name = "Fiodor";
            Surname = "Aikui";
            Region = "UK/GB";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class with specified parameters.
        /// </summary>
        /// <param name="number">The contact number. Must not be null and must be at least 18 characters long.</param>
        /// <param name="name">The first name. Must contain only Latin letters. Can be null.</param>
        /// <param name="surname">The last name. Must contain only Latin letters. Can be null.</param>
        /// <param name="region">The region. Must contain only Latin letters. Can be null.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="number"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="number"/> is too short, or any string field contains non-Latin characters.
        /// </exception>
        public Contact(string? number, string? name, string? surname, string? region)
        {
            Number = number;
            Name = name;
            Surname = surname;
            Region = region;
        }

        /// <summary>
        /// Returns a string representation of the contact in format: "Name Surname - +XX... (Region)".
        /// </summary>
        /// <returns>A human-readable string describing the contact.</returns>
        public override string ToString()
        {
            return $"{Name} {Surname} - {Number} ({Region})";
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="Contact"/> instance.
        /// </summary>
        /// <param name="obj">The object to compare with the current instance.</param>
        /// <returns><see langword="true"/> if the objects are equal; otherwise, <see langword="false"/>.</returns>
        public override bool Equals(object? obj) => Equals(obj as Contact);

        /// <summary>
        /// Determines whether the specified <see cref="Contact"/> is equal to the current instance.
        /// </summary>
        /// <param name="other">The <see cref="Contact"/> to compare with this instance.</param>
        /// <returns><see langword="true"/> if both contacts have identical Name, Surname, Region, and Number; otherwise, <see langword="false"/>.</returns>
        public bool Equals(Contact? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return Name == other.Name &&
                   Surname == other.Surname &&
                   Region == other.Region &&
                   Number == other.Number;
        }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Surname, Region, Number);
        }
    }
}
