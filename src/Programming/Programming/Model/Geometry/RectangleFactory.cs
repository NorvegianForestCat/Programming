namespace Programming.Model.Geometry
{
    /// <summary>
    /// Provides methods to create random instances of <see cref="Rectangular"/>.
    /// Ensures generated rectangles have valid dimensions and positions within a typical UI range.
    /// </summary>
    static class RectangleFactory
    {
        private static readonly Random _random = new();

        /// <summary>
        /// Creates a new random <see cref="Rectangular"/> with random width, length, position, and color.
        /// Dimensions and coordinates are chosen from predefined ranges suitable for on-screen rendering.
        /// </summary>
        /// <returns>A randomly generated <see cref="Rectangular"/> instance.</returns>
        public static Rectangular Randomize() => new Rectangular(_random.Next(10, 100), _random.Next(10, 100), 
            _random.Next(50, 300), _random.Next(50, 300), "Green");
    }
}
