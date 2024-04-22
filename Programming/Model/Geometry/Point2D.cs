using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Services;

namespace Programming.Model.Geometry
{
    class Point2D
    {
        private double _x;
        private double _y;

        public double X
        {
            get => _x;
            set
            {
                Validator.AssertValueInRange(value, 0.0, 500.0, "Point2D.X");
                _x = value;
            }
        }

        public double Y
        {
            get => _y;
            set
            {
                Validator.AssertValueInRange(value, 0.0, 500.0, "Point2D.Y");
                _y = value;
            }
        }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
