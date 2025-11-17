using ObjectOrientedPractics.Services;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Represents a shopping cart that manages a collection of items and calculates their total amount.
    /// Uses external tool <see cref="ItemsTool"/> to compute the total sum.
    /// </summary>
    public class Cart
    {
        private List<Item> _items = new();

        /// <summary>
        /// Gets or sets the list of items in the cart.
        /// The list is initialized by default, but can be replaced.
        /// </summary>
        /// <value>A mutable list of <see cref="Item"/> objects. Never returns <see langword="null"/>.</value>
        public List<Item> Items
        {
            get => _items;
            set => _items = value ?? new List<Item>();
        }

        /// <summary>
        /// Gets the total monetary amount of all items in the cart.
        /// Calculated using the static method <see cref="ItemsTool.GetAmount(List{Item})"/>.
        /// </summary>
        /// <value>The sum of prices of all items. Returns 0 if the list is empty.</value>
        public double Amount => ItemsTool.GetAmount(Items);
    }
}