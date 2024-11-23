using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Item properties calcualtions
    /// </summary>
    public static class ItemsTool
    {
        /// <summary>
        /// Calculate amount cost
        /// </summary>
        /// <param name="items"><see cref="List{Item}"/></param>
        /// <returns>amount cost</returns>
        public static double GetAmount(List<Item> items)
        {
            if (items == null) return 0;

            double total = 0f;
            foreach (var item in items)
            {
                total += item.Cost;
            }
            return total;
        }

        /// <summary>
        /// Amount by category
        /// </summary>
        /// <param name="items">Items</param>
        /// <param name="category">Category</param>
        /// <returns>Amount by category</returns>
        public static double GetAmountOnCategory(List<Item> items, Category category)
        {
            if (items == null)
            {
                return 0;
            }

            double total = 0;

            foreach (Item item in items)
            {
                if (item.Category == category)
                {
                    total += item.Cost;
                }
            }
            return total;
        }
    }
}