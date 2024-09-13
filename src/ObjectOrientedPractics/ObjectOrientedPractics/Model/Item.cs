using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ObjectOrientedPractics.Model
{
    internal class Item
    {
        private readonly int _id;

        private string _name;
        private string? _info;
        private double _cost;

        public int Id
        { 
            get
            {
                return _id;
            } 
        }
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

        public Item()
        {
            Name = "test";
            Info = "test";
            Cost = 1.0;

            _id = -1;
        }

        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;

            _id = IdGenerator.GetNextId();
        }

        public override string ToString() 
        {
            return $"{Id}: {Name} - {Cost}";
        }
    }
}
