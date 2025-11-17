using ObjectOrientedPractics.Services;
using System;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Represents a product or item available for sale in the system.
    /// Includes name, description, price, category, and unique identifier.
    /// </summary>
    public class Item : IEquatable<Item>
    {
        public const int NAME_LENGTH_LIMIT = 200;
        public const int INFO_LENGTH_LIMIT = 1000;
        public const double MINIMUM_COST = 0.0;
        public const double MAXIMUM_COST = 100_000.0;

        private readonly int _id = IdGenerator.GetNextId();
        private string _name = string.Empty;
        private string _info = string.Empty;
        private double _cost;

        /// <summary>
        /// Gets the unique identifier of the item.
        /// Assigned automatically upon creation using <see cref="IdGenerator"/>.
        /// </summary>
        /// <value>An integer ID that is unique across all items.</value>
        public int Id => _id;

        /// <summary>
        /// Gets or sets the name of the item. Must not exceed 200 characters.
        /// </summary>
        /// <value>The display name of the product (e.g., "Notebook A5").</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is longer than 200 characters.
        /// </exception>
        public string Name
        {
            get => _name;
            set
            {
                ValueValidator.AssertStringOnLength(value, NAME_LENGTH_LIMIT, nameof(Name));
                _name = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Gets or sets the description or additional information about the item.
        /// Must not exceed 1000 characters.
        /// </summary>
        /// <value>Detailed info such as specifications, materials, or usage notes.</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is longer than 1000 characters.
        /// </exception>
        public string Info
        {
            get => _info;
            set
            {
                ValueValidator.AssertStringOnLength(value, INFO_LENGTH_LIMIT, nameof(Info));
                _info = value ?? string.Empty;
            }
        }

        /// <summary>
        /// Gets or sets the cost (price) of the item. Must be between 0.0 and 100,000.0.
        /// </summary>
        /// <value>A double representing the monetary value in base currency units.</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is less than 0.0 or greater than 100,000.0.
        /// </exception>
        public double Cost
        {
            get => _cost;
            set
            {
                ValueValidator.AssertDoubleOnLimits(value, MINIMUM_COST, MAXIMUM_COST, nameof(Cost));
                _cost = value;
            }
        }

        /// <summary>
        /// Gets or sets the category of the item.
        /// Used for filtering and organization in the inventory.
        /// </summary>
        /// <value>A <see cref="Category"/> value (e.g., <see cref="Category.Chancellery"/>).</value>
        public Category Category { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class with default values.
        /// </summary>
        public Item()
        {
            Category = Category.Chancellery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class with specified parameters.
        /// </summary>
        /// <param name="name">The name of the item. Must not be null and must be within length limit.</param>
        /// <param name="info">The description of the item. Can be <see langword="null"/>.</param>
        /// <param name="cost">The price of the item. Must be within valid range.</param>
        /// <param name="category">The category to which the item belongs.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="name"/> or <paramref name="cost"/> is invalid.</exception>
        public Item(string name, string? info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        /// <summary>
        /// Creates a shallow copy of the specified item.
        /// Note: The ID is copied, so this is not a true "clone" for persistence contexts.
        /// </summary>
        /// <param name="item">The item to copy. Must not be <see langword="null"/>.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="item"/> is <see langword="null"/>.</exception>
        public Item(Item item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            _id = item._id;
            Name = item.Name;
            Info = item.Info;
            Cost = item.Cost;
            Category = item.Category;
        }

        /// <summary>
        /// Returns a string representation of the item in format: "ID: Name - Cost".
        /// </summary>
        /// <returns>A human-readable string describing the item and its price.</returns>
        public override string ToString() => $"{Id}: {Name} - {_cost:F2}";

        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="Item"/> instance.
        /// </summary>
        /// <param name="obj">The object to compare with this instance.</param>
        /// <returns><see langword="true"/> if the objects are equal; otherwise, <see langword="false"/>.</returns>
        public override bool Equals(object? obj) => Equals(obj as Item);

        /// <summary>
        /// Determines whether the specified <see cref="Item"/> is equal to the current instance.
        /// Two items are considered equal if they have the same <see cref="Id"/>.
        /// </summary>
        /// <param name="other">The <see cref="Item"/> to compare with this instance.</param>
        /// <returns>
        /// <see langword="true"/> if both items have the same ID; otherwise, <see langword="false"/>.
        /// </returns>
        public bool Equals(Item? other)
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