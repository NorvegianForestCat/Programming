using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Represents the central data storage of the application.
    /// Holds collections of items, customers, and tracks used identifiers.
    /// Manages the connection with <see cref="IdGenerator"/> for consistent ID assignment.
    /// </summary>
    public class Store
    {
        private List<int> _busyIds = new();
        private List<Item> _items = new();
        private List<Customer> _customers = new();

        /// <summary>
        /// Gets or sets the list of IDs that are already in use.
        /// This list is shared with <see cref="IdGenerator"/> to prevent ID collisions.
        /// </summary>
        /// <value>A list of integers representing used identifiers.</value>
        public List<int> BusyIds
        {
            get => _busyIds;
            set => _busyIds = value ?? new List<int>();
        }

        /// <summary>
        /// Gets or sets the collection of available items in the store.
        /// </summary>
        /// <value>A list of <see cref="Item"/> objects representing products.</value>
        public List<Item> Items
        {
            get => _items;
            set => _items = value ?? new List<Item>();
        }

        /// <summary>
        /// Gets or sets the collection of registered customers.
        /// </summary>
        /// <value>A list of <see cref="Customer"/> objects.</value>
        public List<Customer> Customers
        {
            get => _customers;
            set => _customers = value ?? new List<Customer>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Store"/> class.
        /// Connects the <see cref="BusyIds"/> list with <see cref="IdGenerator.BusyIds"/>
        /// to ensure consistent ID generation across the application.
        /// </summary>
        public Store()
        {
            IdGenerator.BusyIds = BusyIds;
        }

        /// <summary>
        /// Returns a string representation of the store including item and customer counts.
        /// </summary>
        /// <returns>A formatted string like: "Store (Items: 150, Customers: 87)".</returns>
        public override string ToString()
        {
            return $"Store (Items: {Items.Count}, Customers: {Customers.Count})";
        }
    }
}