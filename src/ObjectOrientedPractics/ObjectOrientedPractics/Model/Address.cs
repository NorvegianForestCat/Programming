using System;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Represents a physical address with index, country, city, street, building, and apartment.
    /// All string fields are validated for length upon assignment.
    /// </summary>
    public class Address : IEquatable<Address>
    {
        public const int INDEX_DIGIT = 6;
        public const int COUNTRY_LENGTH_LIMIT = 50;
        public const int CITY_LENGTH_LIMIT = 50;
        public const int STREET_LENGTH_LIMIT = 100;
        public const int BUILDING_LENGTH_LIMIT = 10;
        public const int APARTMENT_LENGTH_LIMIT = 10;

        private int _index;
        private string _country = string.Empty;
        private string _city = string.Empty;
        private string _street = string.Empty;
        private string _building = string.Empty;
        private string _apartment = string.Empty;

        /// <summary>
        /// Gets or sets the postal index. Must be a positive integer with exactly 6 digits.
        /// </summary>
        /// <value>An integer representing the postal code.</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is not a 6-digit positive number.
        /// </exception>
        public int Index
        {
            get => _index;
            set
            {
                ValueValidator.AssertIntOnDigit(value, INDEX_DIGIT, nameof(Index));
                _index = value;
            }
        }

        /// <summary>
        /// Gets or sets the country name. Must not exceed 50 characters in length.
        /// </summary>
        /// <value>A string representing the country (e.g., "Russia").</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the string is longer than 50 characters.
        /// </exception>
        public string Country
        {
            get => _country;
            set
            {
                ValueValidator.AssertStringOnLength(value, COUNTRY_LENGTH_LIMIT, nameof(Country));
                _country = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Gets or sets the city name. Must not exceed 50 characters in length.
        /// </summary>
        /// <value>A string representing the city (e.g., "Moscow").</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the string is longer than 50 characters.
        /// </exception>
        public string City
        {
            get => _city;
            set
            {
                ValueValidator.AssertStringOnLength(value, CITY_LENGTH_LIMIT, nameof(City));
                _city = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Gets or sets the street name. Must not exceed 100 characters in length.
        /// </summary>
        /// <value>A string representing the street (e.g., "Lenina St.").</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the string is longer than 100 characters.
        /// </exception>
        public string Street
        {
            get => _street;
            set
            {
                ValueValidator.AssertStringOnLength(value, STREET_LENGTH_LIMIT, nameof(Street));
                _street = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Gets or sets the building number. Must not exceed 10 characters in length.
        /// </summary>
        /// <value>A string representing the building (e.g., "12A", "5/3").</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the string is longer than 10 characters.
        /// </exception>
        public string Building
        {
            get => _building;
            set
            {
                ValueValidator.AssertStringOnLength(value, BUILDING_LENGTH_LIMIT, nameof(Building));
                _building = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Gets or sets the apartment number. Must not exceed 10 characters in length.
        /// </summary>
        /// <value>A string representing the apartment (e.g., "45", "7B").</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the string is longer than 10 characters.
        /// </exception>
        public string Apartment
        {
            get => _apartment;
            set
            {
                ValueValidator.AssertStringOnLength(value, APARTMENT_LENGTH_LIMIT, nameof(Apartment));
                _apartment = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class with default values.
        /// </summary>
        public Address()
        {
            Index = 123456;
            Country = string.Empty;
            City = string.Empty;
            Street = string.Empty;
            Building = string.Empty;
            Apartment = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class with specified parameters.
        /// </summary>
        /// <param name="index">The postal index. Must be a 6-digit number.</param>
        /// <param name="country">The country name. Must not exceed 50 characters.</param>
        /// <param name="city">The city name. Must not exceed 50 characters.</param>
        /// <param name="street">The street name. Must not exceed 100 characters.</param>
        /// <param name="building">The building number. Must not exceed 10 characters.</param>
        /// <param name="apartment">The apartment number. Must not exceed 10 characters.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when any parameter fails validation.
        /// </exception>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Returns a string representation of the address in format:
        /// "Index, Country, City, Street, Building, Apartment".
        /// </summary>
        /// <returns>A formatted string describing the full address.</returns>
        public override string ToString()
        {
            return $"{Index}, {Country}, {City}, {Street}, {Building}, {Apartment}";
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="Address"/> instance.
        /// </summary>
        /// <param name="obj">The object to compare with this instance.</param>
        /// <returns><see langword="true"/> if the objects are equal; otherwise, <see langword="false"/>.</returns>
        public override bool Equals(object? obj) => Equals(obj as Address);

        /// <summary>
        /// Determines whether the specified <see cref="Address"/> is equal to the current instance.
        /// </summary>
        /// <param name="other">The <see cref="Address"/> to compare with this instance.</param>
        /// <returns>
        /// <see langword="true"/> if both addresses have identical index, country, city, street, building, and apartment; otherwise, <see langword="false"/>.
        /// </returns>
        public bool Equals(Address? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return Index == other.Index &&
                   Country == other.Country &&
                   City == other.City &&
                   Street == other.Street &&
                   Building == other.Building &&
                   Apartment == other.Apartment;
        }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Index, Country, City, Street, Building, Apartment);
        }
    }
}