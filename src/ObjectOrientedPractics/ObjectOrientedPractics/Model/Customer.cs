using ObjectOrientedPractics.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Represents a customer in the system with personal information, address, shopping cart, and order history.
    /// Each customer has a unique identifier generated automatically.
    /// </summary>
    public class Customer : IEquatable<Customer>
    {
        public const int FULLNAME_LENGTH_LIMIT = 200;

        private readonly int _id = IdGenerator.GetNextId();
        private string _fullname = string.Empty;

        /// <summary>
        /// Gets the unique identifier of the customer.
        /// Assigned automatically upon creation using <see cref="IdGenerator"/>.
        /// </summary>
        /// <value>An integer ID that is unique across all customers.</value>
        public int Id => _id;

        /// <summary>
        /// Gets or sets the full name of the customer. Must not exceed 200 characters.
        /// </summary>
        /// <value>The customer's full name (e.g., "John Doe").</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is longer than 200 characters.
        /// </exception>
        public string Fullname
        {
            get => _fullname;
            set
            {
                ValueValidator.AssertStringOnLength(value, FULLNAME_LENGTH_LIMIT, nameof(Fullname));
                _fullname = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Gets or sets the customer's delivery address.
        /// Cannot be <see langword="null"/> after initialization.
        /// </summary>
        /// <value>An <see cref="Address"/> object representing the customer's location.</value>
        /// <exception cref="ArgumentNullException">Thrown when setting to <see langword="null"/>.</exception>
        public Address Address
        {
            get => _address;
            set => _address = value ?? throw new ArgumentNullException(nameof(value), "Address cannot be null.");
        }
        private Address _address = new();

        /// <summary>
        /// Gets or sets the customer's shopping cart.
        /// Initialized by default with an empty cart.
        /// </summary>
        /// <value>A <see cref="Cart"/> object containing items selected for purchase.</value>
        public Cart Cart { get; set; } = new();

        /// <summary>
        /// Gets or sets the list of orders placed by the customer.
        /// Initialized by default as an empty list.
        /// </summary>
        /// <value>A collection of <see cref="Order"/> objects.</value>
        public List<Order> Orders { get; set; } = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class with default values.
        /// </summary>
        public Customer()
        {
            Fullname = string.Empty;
            Address = new Address();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class with specified fullname and address.
        /// </summary>
        /// <param name="fullname">The full name of the customer. Must not be null or empty and must be within length limit.</param>
        /// <param name="address">The customer's address. Must not be <see langword="null"/>.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="fullname"/> is invalid.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="address"/> is <see langword="null"/>.</exception>
        public Customer(string fullname, Address address)
        {
            Fullname = fullname ?? throw new ArgumentNullException(nameof(fullname));
            Address = address ?? throw new ArgumentNullException(nameof(address));
        }

        /// <summary>
        /// Returns a string representation of the customer in format: "ID: Fullname".
        /// </summary>
        /// <returns>A human-readable string describing the customer.</returns>
        public override string ToString() => $"{Id}: {Fullname}";

        /// <summary>
        /// Private constructor used by JSON deserializer to restore a customer with a specific ID.
        /// </summary>
        /// <param name="id">The ID to assign to the customer.</param>
        [JsonConstructor]
        private Customer(int id)
        {
            _id = id;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="Customer"/> instance.
        /// </summary>
        /// <param name="obj">The object to compare with this instance.</param>
        /// <returns><see langword="true"/> if the objects are equal; otherwise, <see langword="false"/>.</returns>
        public override bool Equals(object? obj) => Equals(obj as Customer);

        /// <summary>
        /// Determines whether the specified <see cref="Customer"/> is equal to the current instance.
        /// </summary>
        /// <param name="other">The <see cref="Customer"/> to compare with this instance.</param>
        /// <returns>
        /// <see langword="true"/> if both customers have the same <see cref="Id"/>; otherwise, <see langword="false"/>.
        /// </returns>
        public bool Equals(Customer? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return Id == other.Id;
        }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for this instance.</returns>
        public override int GetHashCode() => Id;
    }
}