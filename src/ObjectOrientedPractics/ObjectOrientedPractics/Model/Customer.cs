using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Representation of customer
    /// </summary>
    internal class Customer
    {
        /// <summary>
        /// Customer fields
        /// </summary>
        private readonly int _id;
        private string? _fullname;
        private string? _adress;

        /// <summary>
        /// Property Id. Only returns ID.
        /// </summary>
        public int Id { get; }
        /// <summary>
        /// Property Fullname. Gets string fullname and returns fullname string.
        /// </summary>
        public string? Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                if (value == null) return;

                ValueValidator.AssertStringOnLength(value, 200, "Fullname");
                _fullname = value;
            }
        }
        /// <summary>
        /// Property Adress. Gets string Adress and returns adress string.
        /// </summary>
        public string? Adress
        {
            get
            {
                return _adress;
            }
            set
            {
                if (value == null) return;

                ValueValidator.AssertStringOnLength(value, 500, "Adress");
                _adress = value;
            }
        }

        /// <summary>
        /// Class constructor without params
        /// </summary>
        public Customer()
        {
            Fullname = "name";
            Adress = "name";

            Id = -1;
        }

        /// <summary>
        /// Class constructor with params
        /// </summary>
        /// <param name="fullname">Customer fullname</param>
        /// <param name="adress">Customer adress</param>
        public Customer(string fullname, string adress)
        {
            Fullname = fullname;
            Adress = adress;

            Id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// Ovverided ToString() method.
        /// </summary>
        /// <returns>String presentation of customer</returns>
        public override string ToString() 
        {
            return $"{Id}: {Fullname}";
        }
    }
}
