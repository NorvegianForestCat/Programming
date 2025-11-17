using Newtonsoft.Json;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Represents a customer order with items, delivery address, status, and creation date.
    /// Each order has a unique identifier and tracks its lifecycle through <see cref="OrderStatus"/>.
    /// </summary>
    public class Order : IEquatable<Order>
    {
        private readonly int _id = IdGenerator.GetNextId();
        private readonly DateTime _creationDate = DateTime.Now;

        private Address _address = new();
        private List<Item> _items = new();

        /// <summary>
        /// Gets the unique identifier of the order.
        /// Assigned automatically using <see cref="IdGenerator"/>.
        /// </summary>
        /// <value>An integer ID that is unique across all orders.</value>
        public int Id => _id;

        /// <summary>
        /// Gets the date and time when the order was created.
        /// Set to <see cref="DateTime.Now"/> upon instantiation.
        /// </summary>
        /// <value>A <see cref="DateTime"/> value representing the creation timestamp.</value>
        public DateTime CreationDate => _creationDate;

        /// <summary>
        /// Gets or sets the current status of the order.
        /// Reflects the stage in the order fulfillment process.
        /// </summary>
        /// <value>A value from the <see cref="OrderStatus"/> enumeration.</value>
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the delivery address for the order.
        /// Cannot be <see langword="null"/> after initialization.
        /// </summary>
        /// <value>An <see cref="Address"/> object representing the shipping destination.</value>
        /// <exception cref="ArgumentNullException">Thrown when setting to <see langword="null"/>.</exception>
        public Address Address
        {
            get => _address;
            set => _address = value ?? throw new ArgumentNullException(nameof(value), "Address cannot be null.");
        }

        /// <summary>
        /// Gets or sets the list of items included in the order.
        /// Initialized by default as an empty list.
        /// </summary>
        /// <value>A collection of <see cref="Item"/> objects.</value>
        /// <exception cref="ArgumentNullException">Thrown when setting to <see langword="null"/>.</exception>
        public List<Item> Items
        {
            get => _items;
            set => _items = value ?? throw new ArgumentNullException(nameof(value), "Items list cannot be null.");
        }

        /// <summary>
        /// Gets the total monetary amount of all items in the order.
        /// Calculated using the static method <see cref="ItemsTool.GetAmount(List{Item})"/>.
        /// </summary>
        /// <value>The sum of prices of all items. Returns 0 if the list is empty.</value>
        public double Amount => ItemsTool.GetAmount(Items);

        /// <summary>
        /// Initializes a new instance of the <see cref="Order"/> class with default values.
        /// </summary>
        public Order()
        {
            Status = OrderStatus.New;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Order"/> class with specified parameters.
        /// </summary>
        /// <param name="status">The initial status of the order.</param>
        /// <param name="address">The delivery address. Must not be <see langword="null"/>.</param>
        /// <param name="items">The list of items in the order. Must not be <see langword="null"/>.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="address"/> or <paramref name="items"/> is <see langword="null"/>.
        /// </exception>
        public Order(OrderStatus status, Address address, List<Item> items)
        {
            Status = status;
            Address = address;
            Items = items;
        }

        /// <summary>
        /// Private constructor used by JSON deserializer to restore an order with a specific ID.
        /// </summary>
        /// <param name="id">The ID to assign to the order.</param>
        [JsonConstructor]
        private Order(int id)
        {
            _id = id;
        }

        /// <summary>
        /// Returns a string representation of the order in format: "Order #ID (Status)".
        /// </summary>
        /// <returns>A human-readable string describing the order.</returns>
        public override string ToString() => $"Order #{_id} ({Status})";

        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="Order"/> instance.
        /// </summary>
        /// <param name="obj">The object to compare with this instance.</param>
        /// <returns><see langword="true"/> if the objects are equal; otherwise, <see langword="false"/>.</returns>
        public override bool Equals(object? obj) => Equals(obj as Order);

        /// <summary>
        /// Determines whether the specified <see cref="Order"/> is equal to the current instance.
        /// </summary>
        /// <param name="other">The <see cref="Order"/> to compare with this instance.</param>
        /// <returns>
        /// <see langword="true"/> if both orders have the same <see cref="Id"/>; otherwise, <see langword="false"/>.
        /// </returns>
        public bool Equals(Order? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return Id == other.Id;
        }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for this instance based on <see cref="Id"/>.</returns>
        public override int GetHashCode() => Id;
    }
}