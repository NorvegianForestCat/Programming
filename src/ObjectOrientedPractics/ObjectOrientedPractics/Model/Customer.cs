using ObjectOrientedPractics.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Representation of customer
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Class fields
        /// </summary>
        public const int FULLNAME_LENGTH_LIMIT = 200;
        public const int ADDRESS_LENGTH_LIMIT = 500;
        private readonly int _id;
        private string _fullname;

        /// <summary>
        /// Gets id
        /// </summary>
        public int Id
        {
            get => _id;
        }

        /// <summary>
        /// Gets and sets fullname
        /// </summary>
        public string Fullname
        {
            get => _fullname;
            set
            {
                ValueValidator.AssertStringOnLength(
                    value, FULLNAME_LENGTH_LIMIT, nameof(_fullname));
                _fullname = value;
            }
        }

        /// <summary>
        /// Gets and sets adress <see cref="Model.Adress"/>. 
        /// </summary>
        public Adress Address { get; set; }

        /// <summary>
        /// Gets and sets customer cart
        /// </summary>
        public Cart Cart { get; set; } = new Cart();

        /// <summary>
        /// Gets and sets list of customers orders
        /// </summary>
        public List<Order> Orders { get; set; } = new List<Order>();

        /// <summary>
        /// Gets and sets if customer is VIP
        /// </summary>
        public bool IsPriority { get; set; } = false;

        /// <summary>
        /// Constructor <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            Fullname = string.Empty;
            Address = new Adress();
            _id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// Constructor <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Fullname</param>
        /// <param name="address">Address<see cref="Model.Adress"/></param>
        public Customer(string fullname, Adress adress)
        {
            if (String.IsNullOrEmpty(fullname) || adress == null) return;

            Fullname = fullname;
            Address = adress;
            _id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// Overrided ToString method <see cref="Object.ToString()"/>
        /// </summary>
        /// <returns></returns>
        public override string ToString() 
        {
            return $"{Id}: {Fullname}";
        }

        /// <summary>
        /// By-ID constructor
        /// </summary>
        /// <param name="id">ID</param>
        [JsonConstructor]
        public Customer(int id)
        {
            _id = id;
        }
    }
}
