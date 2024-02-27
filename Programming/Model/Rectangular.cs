using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Rectangular
    {
        double _length;
        double _width;
        string? _color;

        // int Length, int value above 0. In another cases - ArgumentException
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if(value > 0)
                {
                    _length = value;
                }
                else
                {
                    throw new ArgumentException("Length must be greater than 0");
                }
            }
        }

        // int Width, int value above 0. In another cases - ArgumentException
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new ArgumentException("Width must be greater than 0");
                }
            }
        }

        // string Color, all values
        public string? Color { get; set; }

        // Base constructor without arguments
        public Rectangular()
        {
            Color = "Black";

            Length = 15;
            Width = 15;
        }

        // Constructor with arguments
        public Rectangular(int length, int width, string color)
        {
            Color = color;

            Length = length;
            Width = width;
        }
    }
}
