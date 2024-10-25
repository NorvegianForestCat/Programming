using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObjectOrientedPractics.Services;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Adress information
    /// </summary>
    public class Adress
    {
        /// <summary>
        /// Class fields
        /// </summary>
        private int? _index;
        private string _country;
        private string _city;
        private string _street;
        private string _building;
        private string _apartment;

        /// <summary>
        /// 
        /// </summary>
        public int? Index
        {
            get
            {
                return _index;
            }
            set
            {
                if (value == null) return;

                ValueValidator.AssertNumberOnLength(value.ToString().Length, 6, "Index");

                _index = value;
            }
        }
        /// <summary>
        /// Gets country string value, returns country
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                if (value == null) return;
                ValueValidator.AssertStringOnLength(value, 50, "Country");

                _country = value;
            }
        }
        /// <summary>
        /// Gets city string value, returns city
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                if (value == null) return;
                ValueValidator.AssertStringOnLength(value, 100, "City");

                _city = value;
            }
        }
        /// <summary>
        /// Gets street string value, returns street
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                if (value == null) return;
                ValueValidator.AssertStringOnLength(value, 100, "Street");

                _street = value;
            }
        }
        /// <summary>
        /// Gets building string value, returns building
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                if (value == null) return;
                ValueValidator.AssertStringOnLength(value, 10, "Building");

                _building = value;
            }
        }
        /// <summary>
        /// Gets apartament string value, returns apartament
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                if (value == null) return;
                ValueValidator.AssertStringOnLength(value, 10, "Apartment");

                _apartment = value;
            }
        }

        /// <summary>
        /// Base constructor without params
        /// </summary>
        public Adress()
        {
            Index = -1;
            Country = "country";
            City = "city";
            Street = "street";
            Building = "building";
            Apartment = "0";
        }

        /// <summary>
        /// Constructor with params
        /// </summary>
        /// <param name="index">Adress index</param>
        /// <param name="country">Adress country</param>
        /// <param name="city">Adress city</param>
        /// <param name="street">Adress street</param>
        /// <param name="building">Adress building</param>
        /// <param name="apartment">Adress apartament</param>
        public Adress(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Constructor of cloning
        /// </summary>
        /// <param name="adress">Cloned adress</param>
        public Adress(Adress adress)
        {
            Index = adress.Index;
            Country = adress.Country;
            City = adress.City;
            Street = adress.Street;
            Building = adress.Building;
            Apartment = adress.Apartment;
        }
    }
}
