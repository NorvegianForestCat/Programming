using ObjectOrientedPractics.Model;
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
    }
}