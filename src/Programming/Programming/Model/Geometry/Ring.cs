using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Services;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Ring content
    /// </summary>
    internal class Ring
    {
        /// <summary>
        /// Ring fields
        /// </summary>
        private Point2D? _center;
        private double _internalRadius;
        private double _externalRadius;

        /// <summary>
        /// Property Center. No validation. Returns and get.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Property InternalRadius. In range 0 - ExternalRadius. Returns and get.
        /// </summary>
        public double InternalRadius
        {
            get => _internalRadius;
            set
            {
                Validator.AssertValueInRange(value, 0, ExternalRadius, "Ring.InternalRadius");
                _internalRadius = value;
            }
        }

        /// <summary>
        /// Property ExternalRadius. In range InternalRadius - 100. Returns and get.
        /// </summary>
        public double ExternalRadius
        {
            get => _externalRadius;
            set
            {
                Validator.AssertValueInRange(value, InternalRadius, 100, "Ring.ExternalRadius");
                _externalRadius = value;
            }
        }

        /// <summary>
        /// Cashable property Area. Only retruns
        /// </summary>
        public double Area
        {
            get => Math.PI * Math.Pow(ExternalRadius, 2) - Math.PI * Math.Pow(InternalRadius, 2);
        }

        /// <summary>
        /// Base constructor
        /// </summary>
        public Ring()
        {
            InternalRadius = 15;
            ExternalRadius = 30;
            Center = new Point2D(0, 0);
        }

        /// <summary>
        /// Constructor with args
        /// </summary>
        /// <param name="center"></param>
        /// <param name="internalRadius"></param>
        /// <param name="externalRadius"></param>
        public Ring(Point2D center, double internalRadius, double externalRadius)
        {
            Center = center;
            InternalRadius = internalRadius;
            ExternalRadius = externalRadius;
        }
    }
}
