using Programming.Model.Services;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Rectangle content
    /// </summary>
    public class Rectangular : IEquatable<Rectangular>
    {
        private double _length;
        private double _width;
        private Point2D? _center;
        private readonly int _id;
        private static int _allRectanglesCount = 0;

        /// <summary>
        /// Gets or sets the length (height) of the rectangle. Must be a positive value.
        /// </summary>
        /// <value>A positive double representing the vertical size.</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is not greater than zero.
        /// </exception>
        public double Length
        {
            get => _length;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }

        /// <summary>
        /// Gets or sets the width of the rectangle. Must be a positive value.
        /// </summary>
        /// <value>A positive double representing the horizontal size.</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is not greater than zero.
        /// </exception>
        public double Width
        {
            get => _width;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        /// <summary>
        /// Gets the unique identifier of this rectangle instance.
        /// Assigned automatically upon creation.
        /// </summary>
        /// <value>An integer ID starting from 0 and incrementing for each new instance.</value>
        public int ID => _id;

        /// <summary>
        /// Gets the total number of <see cref="Rectangular"/> instances created so far.
        /// </summary>
        /// <value>A static counter shared across all instances.</value>
        public static int AllRectanglesCount => _allRectanglesCount;

        /// <summary>
        /// Gets or sets the color of the rectangle.
        /// No validation is performed; can be <see langword="null"/>.
        /// </summary>
        /// <value>A string representing the color (e.g., "Red", "Green").</value>
        public string? Color { get; set; }

        /// <summary>
        /// Gets or sets the center point of the rectangle.
        /// Can be <see langword="null"/>, but typically should be assigned.
        /// </summary>
        /// <value>A <see cref="Point2D"/> object representing the geometric center.</value>
        public Point2D? Center
        {
            get => _center;
            set => _center = value ?? throw new ArgumentNullException(nameof(value), "Center cannot be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangular"/> class with default values.
        /// </summary>
        public Rectangular()
        {
            Color = "Black";
            Length = 15;
            Width = 15;
            Center = new Point2D(1, 1);

            _id = _allRectanglesCount;
            _allRectanglesCount++;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangular"/> class with specified parameters.
        /// </summary>
        /// <param name="length">The length (height) of the rectangle. Must be greater than zero.</param>
        /// <param name="width">The width of the rectangle. Must be greater than zero.</param>
        /// <param name="x">The X coordinate of the center point.</param>
        /// <param name="y">The Y coordinate of the center point.</param>
        /// <param name="color">The color of the rectangle. Can be <see langword="null"/>.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="length"/> or <paramref name="width"/> is not positive.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the generated <see cref="Center"/> point is <see langword="null"/>.
        /// </exception>
        public Rectangular(double length, double width, double x, double y, string? color)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = new Point2D(x, y);

            _id = _allRectanglesCount;
            _allRectanglesCount++;
        }

        /// <summary>
        /// Returns a string representation of the rectangle including ID, position, size, and dimensions.
        /// </summary>
        /// <returns>A formatted string like: "0. (X=100.0, Y=200.0, W=50.0, H=30.0)".</returns>
        public override string ToString()
        {
            return $"{ID}. (X={Center.X:F1}, Y={Center.Y:F1}, W={Width:F1}, H={Length:F1})";
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="Rectangular"/> instance.
        /// </summary>
        /// <param name="obj">The object to compare with this instance.</param>
        /// <returns><see langword="true"/> if the objects are equal; otherwise, <see langword="false"/>.</returns>
        public override bool Equals(object? obj) => Equals(obj as Rectangular);

        /// <summary>
        /// Determines whether the specified <see cref="Rectangular"/> is equal to the current instance.
        /// </summary>
        /// <param name="other">The <see cref="Rectangular"/> to compare with this instance.</param>
        /// <returns>
        /// <see langword="true"/> if both rectangles have identical ID, Center, Width, Length, and Color; otherwise, <see langword="false"/>.
        /// </returns>
        public bool Equals(Rectangular? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return ID == other.ID &&
                   Width == other.Width &&
                   Length == other.Length &&
                   string.Equals(Color, other.Color) &&
                   Center?.Equals(other.Center) == true;
        }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(ID, Width, Length, Color, Center);
        }
    }
}
