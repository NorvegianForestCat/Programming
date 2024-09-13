using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Services;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Rectangle content
    /// </summary>
    class Rectangular
    {
        /// <summary>
        /// Rectangle fields
        /// </summary>
        private double _length;
        private double _width;
        private string? _color;
        private Point2D? _center;
        private readonly int _id;
        private static int _allRectanglesCount = 0;

        /// <summary>
        /// Property Length. OnlyPositive value. Returns and get.
        /// </summary>
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

        /// <summary>
        /// Property Width. Only positive value. Returns and get.
        /// </summary>
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

        /// <summary>
        /// Readonly property ID. Only returns
        /// </summary>
        public int ID
        {
            get => _id;
        }

        /// <summary>
        /// Readonly static property AllRectanglesCount. Only returns
        /// </summary>
        public static int AllRectanglesCount
        {
            get => _allRectanglesCount;
        }

        /// <summary>
        /// Property Color. No validation. Returns and get.
        /// </summary>
        public string? Color { get; set; }

        /// <summary>
        /// Property Center. No validation. Returns and get.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Base constructor
        /// </summary>
        public Rectangular()
        {
            Color = "Black";
            Length = 15;
            Width = 15;
            Center = new Point2D(1, 1);

            _id = AllRectanglesCount;

            _allRectanglesCount++;
        }

        /// <summary>
        /// Constructor with args
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="color"></param>
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
