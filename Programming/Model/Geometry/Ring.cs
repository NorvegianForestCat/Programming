using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Services;

namespace Programming.Model.Geometry
{
    internal class Ring
    {
        private Point2D? _center;
        private double _internalRadius;
        private double _externalRadius;

        // Center of ring
        public Point2D Center { get; set; }

        // Internal radius
        public double InternalRadius
        {
            get => _internalRadius;
            set
            {
                Validator.AssertValueInRange(value, 0, ExternalRadius, "Ring.InternalRadius");
                _internalRadius = value;
            }
        }

        // External radius
        public double ExternalRadius
        {
            get => _externalRadius;
            set
            {
                Validator.AssertValueInRange(value, InternalRadius, 100, "Ring.ExternalRadius");
                _externalRadius = value;
            }
        }

        // Area
        public double Area
        {
            get => Math.PI * Math.Pow(ExternalRadius, 2) - Math.PI * Math.Pow(InternalRadius, 2);
        }

        public Ring()
        {
            InternalRadius = 15;
            ExternalRadius = 30;
            Center = new Point2D(0, 0);
        }

        public Ring(Point2D center, double internalRadius, double externalRadius)
        {
            Center = center;
            InternalRadius = internalRadius;
            ExternalRadius = externalRadius;
        }
    }
}
