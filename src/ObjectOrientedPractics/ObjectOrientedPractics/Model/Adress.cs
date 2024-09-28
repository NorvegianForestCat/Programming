using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObjectOrientedPractics.Services;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Adress
    {
        /// <summary>
        /// 
        /// </summary>
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _building;
        private string _apartment;

        /// <summary>
        /// 
        /// </summary>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                if (!int.IsPositive(value)) return;
                ValueValidator.AssertNumberOnLength(value, 6, "Index");

                _index = value;
            }
        }
        /// <summary>
        /// 
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
        /// 
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
        /// 
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
        /// 
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
        /// 
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
        /// 
        /// </summary>
        public Adress()
        {
            Index = 0;
            Country = "country";
            City = "city";
            Street = "street";
            Building = "building";
            Apartment = "0";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="street"></param>
        /// <param name="building"></param>
        /// <param name="apartment"></param>
        public Adress(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}
