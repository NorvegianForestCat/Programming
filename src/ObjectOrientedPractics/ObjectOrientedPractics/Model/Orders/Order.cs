using Newtonsoft.Json;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Net;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Provides order data
    /// </summary>
    public class Order : IEquatable<Order>
    {
        /// <summary>
        /// Class fields
        /// </summary>
        private readonly int _id;
        [JsonProperty]
        private readonly DateTime _date = DateTime.Now;

        /// <summary>
        /// Gets ID
        /// </summary>
        public int Id
        {
            get => _id;
        }

        /// <summary>
        /// Gets date
        /// </summary>
        public DateTime CreationDate
        {
            get => _date;
        }

        /// <summary>
        /// Gets and sets status
        /// </summary>
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Gets and sets address
        /// </summary>
        public Adress Address { get; set; }

        /// <summary>
        /// Gets and sets list of items
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Order discount
        /// </summary>
        public double DiscountAmount { get; }

        /// <summary>
        /// Gets total price
        /// </summary>
        public double Total
        {
            get
            {
                return Amount - DiscountAmount;
            }
        }

        /// <summary>
        /// Gets and sets 
        /// </summary>
        public double Amount
        {
            get
            {
                return ItemsTool.GetAmount(Items);
            }
        }

        /// <summary>
        /// Constructor without params
        /// </summary>
        public Order()
        {
            _id = IdGenerator.GetNextId();
            Status = OrderStatus.New;
            Address = new Adress();
            Items = new List<Item>();
            DiscountAmount = 0;
        }

        /// <summary>
        /// Constructor with params
        /// </summary>
        /// <param name="status">Status</param>
        /// <param name="address">Adress</param>
        /// <param name="items">Items list</param>
        /// <param name="creationDate">Date of creation</param>
        public Order(OrderStatus status, Adress address, List<Item> items, double discountAmount)
        {
            _id = IdGenerator.GetNextId();
            Status = status;
            Address = address;
            Items = items;
            DiscountAmount = discountAmount;
        }

        /// <summary>
        /// By-ID constructor
        /// </summary>
        /// <param name="id">ID</param>
        [JsonConstructor]
        public Order(int id, double discountAmount)
        {
            _id = id;
            DiscountAmount = discountAmount;
        }

        /// <summary>
        /// Is equal with?
        /// </summary>
        /// <param name="other"><see cref="Order"/></param>
        /// <returns>bool if equal</returns>
        public bool Equals(Order other)
        {
            if (other == null)
            {
                return false;
            }

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Id == other.Id;
        }
    }
}