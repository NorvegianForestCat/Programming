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
        private readonly int _id;
        private string _name;
        private string? _info;
        private double _cost;
        private Category _category;

        /// <summary>
        /// Property Id. Only returns ID.
        /// </summary>
        public int Id
        { 
            get
            {
                return _id;
            } 
        }
        /// <summary>
        /// Property Name. Gets string name and returns name string.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) return;

                ValueValidator.AssertStringOnLength(value, 200, "Name");
                _name = value;
            }
        }
        /// <summary>
        /// Property Info. Gets string info and returns info string.
        /// </summary>
        public string? Info
        {
            get
            { 
                return _info;
            }
            set
            {
                if(string.IsNullOrEmpty(value)) return;

                ValueValidator.AssertStringOnLength(value, 1000, "Info");
                _info = value;
            } 
        }
        /// <summary>
        /// Property Cost. Gets double cost and returns cost double.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if (!double.IsPositive(value)) return;

                ValueValidator.AssertNumberOnLength(value, 100000.0, "Cost");
                _cost = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Class constructor without params
        /// </summary>
        public Item()
        {
            Name = "test";
            Info = "test";
            Cost = 1.0;
            Category = Category.Chancellery;

            _id = -1;
        }

        /// <summary>
        /// Class constructor with params
        /// </summary>
        /// <param name="name">Item name</param>
        /// <param name="info">Item desciption</param>
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
        /// Overrided ToString() method.
        /// </summary>
        /// <returns>String presentation of item</returns>
        public override string ToString() 
        {
            return $"{Id}: {Name} - {Cost}";
        }
    }
}
