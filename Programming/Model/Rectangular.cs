using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Rectangular
    {
        private double _length;
        private double _width;
        private string? _color;
        private Point2D? _center;
        private readonly int _id;
        private static int _allRectanglesCount = 0;

        // int Length, int value above 0. In another cases - ArgumentException
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Length");
                _length = value;
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
                Validator.AssertOnPositiveValue(value, "Width");
                _width = value;
            }
        }

        public int ID
        {
            get => _id;
        }

        public int AllRectanglesCount
        {
            get => _allRectanglesCount;
        }

        // string Color, all values
        public string? Color { get; set; }

        public Point2D Center { get; set; }

        // Base constructor without arguments
        public Rectangular()
        {
            Color = "Black";
            Length = 15;
            Width = 15;
            Center = new Point2D(7.5, 7.5);

            _id = AllRectanglesCount;

            _allRectanglesCount++;
        }

        // Constructor with arguments
        public Rectangular(int length, int width, string color)
        {
            Color = color;
            Length = length;
            Width = width;
            Center = new Point2D(Length / 2, Width / 2);

            _id = AllRectanglesCount;

            _allRectanglesCount++;
        }
    }
}
