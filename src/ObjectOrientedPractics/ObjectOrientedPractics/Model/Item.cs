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
                if (value == String.Empty)
                {
                    throw new ArgumentException("String name must be not empty");
                }
                _name = value;
            }
        }
        public string? Info { get; set; }
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if (!(value > 0.0))
                {
                    throw new ArgumentException("Price must be positive value");
                }
                _cost = value;
            }
        }



        public Item(string name, string info, double cost)
        {
            _id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;

        }
    }
}
