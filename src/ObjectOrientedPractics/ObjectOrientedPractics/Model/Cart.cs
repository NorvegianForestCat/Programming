using ObjectOrientedPractics.Services;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Provides Cart funcs
    /// </summary>
    public class Cart
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
    }
}