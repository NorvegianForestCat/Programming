using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Services;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Point info
    /// </summary>
    class Point2D
    {
        /// <summary>
        /// Field of point
        /// </summary>
        private double _x;
        private double _y;

        /// <summary>
        /// Property X. Only pos digits. Returns and get.
        /// </summary>
        public double X
        {
            get => _x;
            set
            {
                Validator.AssertValueInRange(value, 0.0, 500.0, "Point2D.X");
                _x = value;
            }
        }

        /// <summary>
        /// Property Y. Only positive digits. Returns and get.
        /// </summary>
        public double Y
        {
            get => _y;
            set
            {
                Validator.AssertValueInRange(value, 0.0, 500.0, "Point2D.Y");
                _y = value;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="y">y</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// String reflexion
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
