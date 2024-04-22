using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Services;

namespace Programming.Model.Geometry
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

        public static int AllRectanglesCount
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
            Center = new Point2D(1, 1);

            _id = AllRectanglesCount;

            _allRectanglesCount++;
        }

        // Constructor with arguments
        public Rectangular(int length, int width, int x, int y, string color)
        {
            Color = color;
            Length = length;
            Width = width;
            Center = new Point2D(x, y);

            _id = AllRectanglesCount;

            _allRectanglesCount++;
        }

        public override string ToString()
        {
            return $"{ID}. (X={Center.X}, Y={Center.Y}, W={Width}, H={Length})";
        }
    }
}
