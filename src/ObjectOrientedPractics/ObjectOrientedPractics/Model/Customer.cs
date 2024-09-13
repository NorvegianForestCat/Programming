using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Customer
    {
        private readonly int _id;

        private string? _fullname;
        private string? _adress;
        
        public int Id { get; }
        public string? Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                if (value == null) return;

                ValueValidator.AssertStringOnLength(value.Length, 200, "Fullname");
                _fullname = value;
            }
        }
        public string? Adress 
        {
            get
            {
                return _adress;
            }
            set
            {
                if (value == null) return;

                ValueValidator.AssertStringOnLength(value.Length, 500, "Adress");
                _adress = value;
            }
        }

        public Customer(string fullname, string adress)
        {
            Fullname = fullname;
            Adress = adress;

            Id = IdGenerator.GetNextId();
        }
    }
}
