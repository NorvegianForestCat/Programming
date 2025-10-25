namespace Programming.Model.Geometry
{
    /// <summary>
    /// Represents a ring (annulus) defined by a center point, internal radius, and external radius.
    /// The area between the two circles is considered the ring's surface.
    /// </summary>
    public class Ring : IEquatable<Ring>
    {
        private Point2D? _center;
        private double _internalRadius;
        private double _externalRadius;

        /// <summary>
        /// Gets or sets the center point of the ring.
        /// </summary>
        /// <value>A <see cref="Point2D"/> object representing the geometric center. Cannot be <see langword="null"/>.</value>
        /// <exception cref="ArgumentNullException">Thrown when set to <see langword="null"/>.</exception>
        public Point2D Center
        {
            get => _center ?? throw new InvalidOperationException("Center is not initialized.");
            set => _center = value ?? throw new ArgumentNullException(nameof(value), "Center cannot be null.");
        }

        /// <summary>
        /// Gets or sets the internal (inner) radius of the ring. Must be non-negative and less than <see cref="ExternalRadius"/>.
        /// </summary>
        /// <value>A double representing the inner circle radius.</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is negative or greater than or equal to <see cref="ExternalRadius"/>.
        /// </exception>
        public double InternalRadius
        {
            get => _internalRadius;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Internal radius cannot be negative.", nameof(value));

                if (value >= _externalRadius)
                    throw new ArgumentException("Internal radius must be less than ExternalRadius.", nameof(value));

                _internalRadius = value;
            }
        }

        /// <summary>
        /// Gets or sets the external (outer) radius of the ring. Must be greater than <see cref="InternalRadius"/> and positive.
        /// </summary>
        /// <value>A double representing the outer circle radius.</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is not greater than <see cref="InternalRadius"/> or not positive.
        /// </exception>
        public double ExternalRadius
        {
            get => _externalRadius;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("External radius must be positive.", nameof(value));

                if (value <= _internalRadius)
                    throw new ArgumentException("External radius must be greater than InternalRadius.", nameof(value));

                _externalRadius = value;
            }
        }

        /// <summary>
        /// Gets the area of the ring (annulus), calculated as π(R²−r²).
        /// </summary>
        /// <value>The surface area between the external and internal circles.</value>
        public double Area => Math.PI * (Math.Pow(_externalRadius, 2) - Math.Pow(_internalRadius, 2));

        /// <summary>
        /// Initializes a new instance of the <see cref="Ring"/> class with default values.
        /// </summary>
        public Ring()
        {
            Center = new Point2D(0, 0);
            _internalRadius = 15;
            _externalRadius = 30;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ring"/> class with specified parameters.
        /// </summary>
        /// <param name="center">The center point of the ring. Must not be <see langword="null"/>.</param>
        /// <param name="internalRadius">The inner radius. Must be non-negative and less than <paramref name="externalRadius"/>.</param>
        /// <param name="externalRadius">The outer radius. Must be greater than <paramref name="internalRadius"/>.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="center"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentException">
        /// Thrown when radii are out of valid range.
        /// </exception>
        public Ring(Point2D center, double internalRadius, double externalRadius)
        {
            Center = center ?? throw new ArgumentNullException(nameof(center));

            if (externalRadius <= 0)
                throw new ArgumentException("External radius must be positive.", nameof(externalRadius));

            _externalRadius = externalRadius;

            if (internalRadius < 0 || internalRadius >= _externalRadius)
                throw new ArgumentException($"Internal radius must be in range [0, {_externalRadius}).", nameof(internalRadius));

            _internalRadius = internalRadius;
        }

        /// <summary>
        /// Returns a string representation of the ring including center, radii, and area.
        /// </summary>
        /// <returns>A formatted string like: "Ring(Center=(0,0), R=30.0, r=15.0, Area=2120.6)".</returns>
        public override string ToString()
        {
            return $"Ring(Center={Center}, R={_externalRadius:F1}, r={_internalRadius:F1}, Area={Area:F1})";
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="Ring"/> instance.
        /// </summary>
        /// <param name="obj">The object to compare with this instance.</param>
        /// <returns><see langword="true"/> if the objects are equal; otherwise, <see langword="false"/>.</returns>
        public override bool Equals(object? obj) => Equals(obj as Ring);

        /// <summary>
        /// Determines whether the specified <see cref="Ring"/> is equal to the current instance.
        /// </summary>
        /// <param name="other">The <see cref="Ring"/> to compare with this instance.</param>
        /// <returns>
        /// <see langword="true"/> if both rings have identical center, internal and external radii; otherwise, <see langword="false"/>.
        /// </returns>
        public bool Equals(Ring? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return Center.Equals(other.Center) &&
                   Math.Abs(_internalRadius - other._internalRadius) < 1e-6 &&
                   Math.Abs(_externalRadius - other._externalRadius) < 1e-6;
        }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(Center, _internalRadius, _externalRadius);
        }
    }
}