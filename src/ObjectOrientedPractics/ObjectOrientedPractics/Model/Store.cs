using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Provides control entire store elements (items and customers)
    /// </summary>
    internal class Store
    {
        /// <summary>
        /// Class fields
        /// </summary>
        private BindingList<Item> _items;
        private BindingList<Customer> _customers;

        /// <summary>
        /// Gets bindingList of items
        /// </summary>
        public BindingList<Item> Items
        {

            get => _items;
            set
            {
                if (value == null) return;
                _items = value;
            }
        }

        /// <summary>
        /// Gets bindingList of customers
        /// </summary>
        public BindingList<Customer> Customers
        {
            get => _customers;
            set
            {
                if (value == null) return;
                _customers = value;
            }
        }

        /// <summary>
        /// Base constructor
        /// </summary>
        public Store() 
        {
            Items = new BindingList<Item> { };
            Customers = new BindingList<Customer> { };
        }
    }
}
