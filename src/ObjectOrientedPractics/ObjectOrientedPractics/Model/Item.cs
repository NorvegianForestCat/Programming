using ObjectOrientedPractics.Services;
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
    public class Item
    {
        /// <summary>
        /// Class fields
        /// </summary>
        public const int NAME_LENGTH_LIMIT = 200;
        public const int INFO_LENGTH_LIMIT = 1000;
        public const double MINIMUM_COST = 0;
        public const double MAXIMUM_COST = 100000;
        private readonly int _id = IdGenerator.GetNextId();
        private string _name;
        private string _info;
        private double _cost;

        /// <summary>
        /// Gets and sets category <see cref="Model.Category"/>.
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
        }

        public Item(Item item)
        {
            _id = item.Id;
            Name = item.Name;
            Info = item.Info;
            Cost = item.Cost;
            Category = item.Category;
        }

        /// <summary>
        /// Overrided ToString() method.
        /// </summary>
        /// <returns>String presentation of item</returns>
        public override string ToString() 
        {
            return $"{Id}: {Name} - {Cost}";
        }
    }
}
