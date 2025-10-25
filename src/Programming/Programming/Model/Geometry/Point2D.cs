using Programming.Model.Services;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Represents a point in two-dimensional space with X and Y coordinates.
    /// Coordinates are constrained to the range [0.0, 500.0] to fit within a predefined area.
    /// </summary>
    public class Point2D : IEquatable<Point2D>
    {
        private double _x;
        private double _y;

        /// <summary>
        /// Gets or sets the X coordinate of the point. Must be in the range [0.0, 500.0].
        /// </summary>
        /// <value>A double representing the horizontal position.</value>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the value is less than 0.0 or greater than 500.0.
        /// </exception>
        public double X
        {
            get => _x;
            set
            {
                Validator.AssertValueInRange(value, 0.0, 500.0, nameof(X));
                _x = value;
            }
        }

        /// <summary>
        /// Gets or sets the Y coordinate of the point. Must be in the range [0.0, 500.0].
        /// </summary>
        /// <value>A double representing the vertical position.</value>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the value is less than 0.0 or greater than 500.0.
        /// </exception>
        public double Y
        {
            get => _y;
            set
            {
                Validator.AssertValueInRange(value, 0.0, 500.0, nameof(Y));
                _y = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point2D"/> class with specified coordinates.
        /// </summary>
        /// <param name="x">The X coordinate. Must be in the range [0.0, 500.0].</param>
        /// <param name="y">The Y coordinate. Must be in the range [0.0, 500.0].</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when <paramref name="x"/> or <paramref name="y"/> is outside the valid range.
        /// </exception>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Returns a string representation of the point in format: "(X, Y)".
        /// </summary>
        /// <returns>A string such as "(100.0, 200.5)".</returns>
        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="Point2D"/> instance.
        /// </summary>
        /// <param name="obj">The object to compare with this instance.</param>
        /// <returns><see langword="true"/> if the objects are equal; otherwise, <see langword="false"/>.</returns>
        public override bool Equals(object? obj) => Equals(obj as Point2D);

        /// <summary>
        /// Determines whether the specified <see cref="Point2D"/> is equal to the current instance.
        /// </summary>
        /// <param name="other">The <see cref="Point2D"/> to compare with this instance.</param>
        /// <returns>
        /// <see langword="true"/> if both points have identical X and Y coordinates; otherwise, <see langword="false"/>.
        /// </returns>
        public bool Equals(Point2D? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return Math.Abs(X - other.X) < 1e-6 &&
                   Math.Abs(Y - other.Y) < 1e-6;
        }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
    }
}
