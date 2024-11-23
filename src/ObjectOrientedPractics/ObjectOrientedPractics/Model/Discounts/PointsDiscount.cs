using Newtonsoft.Json;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Provides discount point funcs
    /// </summary>
    public class PointsDiscount : IDiscount, IComparable<PointsDiscount>
    {
        /// <summary>
        /// Class fields
        /// </summary>
        private int _points;

        /// <summary>
        /// Get abd set discount points
        /// </summary>
        public int Points
        {
            get => _points;
            private set
            {
                ValueValidator.AssertIntOnLowerLimit(value, 0, nameof(Points));
                _points = value;
            }
        }

        /// <summary>
        /// Gets and sets discount info
        /// </summary>
        public string Info
        {
            get
            {
                return $"{Points} points";
            }
        }

        /// <summary>
        /// Calculate discount value
        /// </summary>
        /// <param name="items">Items</param>
        /// <returns>Discount value</returns>
        public double Calculate(List<Item> items)
        {
            double amount = ItemsTool.GetAmount(items);

            if (Points / amount > 0.3)
            {
                return amount * 0.3;
            }
            else
            {
                return Points;
            }
        }

        /// <summary>
        /// Applying discount
        /// </summary>
        /// <param name="items">Items</param>
        /// <returns>Discount value</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);

            Points -= (int)discount;
            return discount;
        }

        /// <summary>
        /// Updating discount points
        /// </summary>
        /// <param name="items">Items</param>
        public void Update(List<Item> items)
        {
            double amount = ItemsTool.GetAmount(items);
            Points += (int)Math.Ceiling(amount * 0.1);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public PointsDiscount()
        {
            Points = 0;
        }

        [JsonConstructor]
        private PointsDiscount(int points)
        {
            Points = points;
        }

        /// <summary>
        /// Compare with object
        /// </summary>
        /// <param name="other"><see cref="PointsDiscount"/>.</param>
        /// <returns>
        /// </returns>
        public int CompareTo(PointsDiscount other)
        {
            if (this.Points == other.Points)
            {
                return 0;
            }
            else if (this.Points > other.Points)
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