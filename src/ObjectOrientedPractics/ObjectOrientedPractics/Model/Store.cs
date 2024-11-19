using ObjectOrientedPractics.Services;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Provides store info
    /// </summary>
    public class Store
    {
        /// <summary>
        /// gets and sets list if busied ids
        /// </summary>
        public List<int> BusyIds { get; set; } = new List<int>();

        /// <summary>
        /// Gets and sets list of <see cref="Item"/>.
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();

        /// <summary>
        /// List of <see cref="Customer"/>.
        /// </summary>
        public List<Customer> Customers { get; set; } = new List<Customer>();

        public Store()
        {
            IdGenerator.BusyIds = BusyIds;
        }
    }
}