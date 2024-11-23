using Newtonsoft.Json;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Provides discount percents funcs
    /// </summary>
    public class PercentDiscount : IDiscount, IComparable<PointsDiscount>
    {
        /// <summary>
        /// Class fields
        /// </summary>
        private int _discount;

        /// <summary>
        /// Get and set discount
        /// </summary>
        public int Discount
        {
            get => _discount;
            private set
            {
                ValueValidator.AssertIntOnLimits(value, 1, 10, nameof(Discount));
                _discount = value;
            }
        }

        /// <summary>
        /// Get and set discount category
        /// </summary>
        public Category Category { get; }

        /// <summary>
        /// Get and set value of spended oer category
        /// </summary>
        public double SpendingPerCategory { get; private set; } = 0;

        /// <summary>
        /// Discount info
        /// </summary>
        public string Info
        {
            get
            {
                return $"Percent \"{Category}\" - {Discount}%";
            }
        }

        /// <summary>
        /// Calculate discount
        /// </summary>
        /// <param name="items">Items</param>
        /// <returns>Discount size</returns>
        public double Calculate(List<Item> items)
        {
            double amount = ItemsTool.GetAmountOnCategory(items, Category);
            return amount * Discount / 100;
        }

        /// <summary>
        /// Applying discount
        /// </summary>
        /// <param name="items">Items</param>
        /// <returns>Discount</returns>
        public double Apply(List<Item> items)
        {
            return Calculate(items);
        }

        /// <summary>
        /// Upadate discount percent
        /// </summary>
        /// <param name="items">Items</param>
        public void Update(List<Item> items)
        {
            double amount = ItemsTool.GetAmountOnCategory(items, Category);
            SpendingPerCategory += amount;
            int percentage = (int)(SpendingPerCategory / 1000) + 1;

            if (percentage > 10)
            {
                Discount = 10;
            }
            else
            {
                Discount = percentage;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="category">Discount category</param>
        public PercentDiscount(Category category)
        {
            Category = category;
            Discount = 1;
        }

        [JsonConstructor]
        private PercentDiscount(Category category, int discount, double spendingPerCategory)
        {
            Category = category;
            Discount = discount;
            SpendingPerCategory = spendingPerCategory;
        }

        /// <summary>
        /// Comapre with other
        /// </summary>
        /// <param name="other"><see cref="PercentDiscount"/>.</param>
        /// <returns>
        /// </returns>
        public int CompareTo(PercentDiscount other)
        {
            if (this.Discount == other.Discount)
            {
                return 0;
            }
            else if (this.Discount > other.Discount)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}