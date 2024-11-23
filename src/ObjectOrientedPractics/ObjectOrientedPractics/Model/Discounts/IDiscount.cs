using System.Collections.Generic;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Discount interface
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Discount information
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Calculate discount value
        /// </summary>
        /// <param name="items">Items</param>
        /// <returns>Discount value</returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Applying discount to items
        /// </summary>
        /// <param name="items">Items</param>
        /// <returns>Discount value</returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Update discount value
        /// </summary>
        /// <param name="items">Items</param>
        void Update(List<Item> items);
    }
}