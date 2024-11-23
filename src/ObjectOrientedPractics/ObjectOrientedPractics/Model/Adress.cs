using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObjectOrientedPractics.Services;
using System.Threading.Tasks;
using System.Net;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Adress information
    /// </summary>
    public class Adress : ICloneable, IEquatable<Item>
    {
        /// <summary>
        /// Class fields
        /// </summary>
        public const int INDEX_DIGIT = 6;
        public const int COUNTRY_LENGTH_LIMIT = 50;
        public const int CITY_LENGTH_LIMIT = 50;
        public const int STREET_LENGTH_LIMIT = 100;
        public const int BUILDING_LENGTH_LIMIT = 10;
        public const int APARTMENT_LENGTH_LIMIT = 10;
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _building;
        private string _apartment;

        /// <summary>
        /// Gets and sets index
        /// </summary>
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
        /// Gets and sets country
        /// </summary>
        public string Country
        {
            get => _country;
            set
            {
                ValueValidator.AssertStringOnLength(value, COUNTRY_LENGTH_LIMIT, nameof(Country));
                _country = value;
            }
        }

        /// <summary>
        /// Gets and sets city
        /// </summary>
        public string City
        {
            get => _city;
            set
            {
                ValueValidator.AssertStringOnLength(value, CITY_LENGTH_LIMIT, nameof(City));
                _city = value;
            }
        }

        /// <summary>
        /// Gets and sets street
        /// </summary>
        public string Street
        {
            get => _street;
            set
            {
                ValueValidator.AssertStringOnLength(value, STREET_LENGTH_LIMIT, nameof(Street));
                _street = value;
            }
        }

        /// <summary>
        /// Gets and sets building number
        /// </summary>
        public string Building
        {
            get => _building;
            set
            {
                ValueValidator.AssertStringOnLength(
                    value,
                    BUILDING_LENGTH_LIMIT,
                    nameof(Building));
                _building = value;
            }
        }

        /// <summary>
        /// Gets and sets apartament number
        /// </summary>
        public string Apartment
        {
            get => _apartment;
            set
            {
                ValueValidator.AssertStringOnLength(
                    value,
                    APARTMENT_LENGTH_LIMIT,
                    nameof(Apartment));
                _apartment = value;
            }
        }

        /// <summary>
        /// Class constructor <see cref="Adress"/>.
        /// </summary>
        public Adress()
        {
            Index = 123456;
            Country = string.Empty;
            City = string.Empty;
            Street = string.Empty;
            Building = string.Empty;
            Apartment = string.Empty;
        }

        /// <summary>
        /// Class constructor <see cref="Adress"/>.
        /// </summary>
        /// <param name="index">Index</param>
        /// <param name="country">Country</param>
        /// <param name="city">City</param>
        /// <param name="street">Street</param>
        /// <param name="building">Building munber</param>
        /// <param name="apartment">Apartemnt number</param>
        public Adress(
            int index,
            string country,
            string city,
            string street,
            string building,
            string apartment
            )
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Copy <see cref="Adress"/>.
        /// </summary>
        /// <returns>Copy by <see cref="object"/></returns>
        public object Clone()
        {
            return new Adress(
                this.Index,
                this.Country,
                this.City,
                this.Street,
                this.Building,
                this.Apartment);
        }

        /// <summary>
        /// Equality with other
        /// </summary>
        /// <param name="other"><see cref="Adress"/></param>
        /// <returns>Bool if equal</returns>
        public bool Equals(Adress other)
        {
            if (other == null)
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            bool result = this.Index == other.Index;
            result &= this.Country == other.Country;
            result &= this.City == other.City;
            result &= this.Street == other.Street;
            result &= this.Building == other.Building;
            result &= this.Apartment == other.Apartment;

            return result;
        }
    }
}
