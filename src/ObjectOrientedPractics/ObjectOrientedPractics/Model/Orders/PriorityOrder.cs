using System;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Provides functions for prioritize order
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Gets and set delivery date
        /// </summary>
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// Gets and sets delivery time (enum)
        /// </summary>
        public OrderTime DeliveryTime { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="status">Order status</param>
        /// <param name="adress">Delivery adress</param>
        /// <param name="items">Delivery items</param>
        public PriorityOrder(
            OrderStatus status,
            Adress adress,
            List<Item> items, double discountAmount) : base(status, adress, items, discountAmount)
        {

        }
    }
}