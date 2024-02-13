using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Rectangular
    {
        double length;
        double width;
        string? color;

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if(value > 0)
                {
                    length = value;
                }
                else
                {
                    throw new ArgumentException("Length must be greater than 0");
                }
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    throw new ArgumentException("Width must be greater than 0");
                }
            }
        }

        public string? Color
        {
            get
            {
                return color;
            }
            set
            {
                if (value != null)
                {
                    color = value;
                }
                else
                {
                    throw new ArgumentException("Color must be");
                }
            }
        }

        public Rectangular()
        {
            Color = "Black";

            Length = 15;
            Width = 15;
        }


        public Rectangular(int length, int width, string color)
        {
            Color = color;

            Length = length;
            Width = width;
        }
    }
}
