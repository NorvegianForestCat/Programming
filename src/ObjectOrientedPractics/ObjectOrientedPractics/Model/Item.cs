using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Representation of item
    /// </summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {
        /// <summary>
        /// Class fields
        /// </summary>
        public const int NAME_LENGTH_LIMIT = 200;
        public const int INFO_LENGTH_LIMIT = 1000;
        public const double MINIMUM_COST = 0;
        public const double MAXIMUM_COST = 100000;
        private readonly int _id;
        private string _name;
        private string _info;
        private double _cost;

        /// <summary>
        /// Gets and sets category <see cref="Enums.Category"/>
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Gets ID
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Gets and sets name
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, NAME_LENGTH_LIMIT, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Gets and sets information
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, INFO_LENGTH_LIMIT, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Gets and sets cost
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                ValueValidator.AssertDoubleOnLimits(
                    value, MINIMUM_COST, MAXIMUM_COST, nameof(Cost));
                _cost = value;
            }
        }

        /// <summary>
        /// Constructor <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            Name = string.Empty;
            Info = string.Empty;
            Cost = 0;
            Category = Category.Chancellery;

            _id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// Constructor <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Item name</param>
        /// <param name="info">Item description</param>
        /// <param name="cost">Item cost</param>
        /// <param name="category">Item category</param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;

            _id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">ID</param>
        [JsonConstructor]
        public Item(int id)
        {
            _id = id;
        }

        /// <summary>
        /// Overrided ToString() method.
        /// </summary>
        /// <returns>String presentation of item</returns>
        public override string ToString() 
        {
            return $"{Id}: {Name} - {Cost}";
        }

        /// <summary>
        /// Copy
        /// </summary>
        /// <returns>Copy <see cref="object"/>.</returns>
        public object Clone()
        {
            var item = new Item(this.Id);
            item.Name = this.Name;
            item.Info = this.Info;
            item.Cost = this.Cost;
            item.Category = this.Category;
            return item;
        }

        /// <summary>
        /// Equallity with other object
        /// </summary>
        /// <param name="other"><see cref="Item"/></param>
        /// <returns>Bool, equal is</returns>
        public bool Equals(Item other)
        {
            if (other == null) return false;

            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Id == other.Id;
        }

        /// <summary>
        /// Comparing with other
        /// </summary>
        /// <param name="other"><see cref="Item"/></param>
        /// <returns>
        /// 0 - equal;
        /// 1 - Greater than other;
        /// -1 - Less tahn other;
        /// </returns>
        public int CompareTo(Item other)
        {
            if (this.Cost == other.Cost)
            {
                return 0;
            }
            else if (this.Cost > other.Cost)
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
