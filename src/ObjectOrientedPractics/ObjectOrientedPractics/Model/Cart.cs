using ObjectOrientedPractics.Services;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Provides Cart funcs
    /// </summary>
    public class Cart : ICloneable
    {
        /// <summary>
        /// Gets and sets list of <see cref="Item"/>
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();

        /// <summary>
        /// Returns amount
        /// </summary>
        public double Amount
        {
            get
            {
                return ItemsTool.GetAmount(Items);
            }
        }

        /// <summary>
        /// Copy <see cref="Cart"/>.
        /// </summary>
        /// <returns>Copy by <see cref="object"/></returns>
        public object Clone()
        {
            Cart cart = new Cart();

            foreach (Item item in this.Items)
            {
                cart.Items.Add((Item)item.Clone());
            }

            return cart;
        }
    }
}