﻿using ObjectOrientedPractics.Services;
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
        private readonly int _id = IdGenerator.GetNextId();
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
        /// Возвращает и задает корзину покупателя.
        /// </summary>
        public Cart Cart { get; set; } = new Cart();

        /// <summary>
        /// Возвращает и задает список заказов покупателя.
        /// </summary>
        public List<Order> Orders { get; set; } = new List<Order>();

        /// <summary>
        /// Constructor <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            Fullname = string.Empty;
            Address = new Adress();
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
