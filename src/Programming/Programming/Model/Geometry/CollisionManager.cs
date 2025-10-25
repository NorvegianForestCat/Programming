namespace Programming.Model.Geometry
{
    /// <summary>
    /// Provides static methods to detect collisions between geometric shapes.
    /// </summary>
    static class CollisionManager
    {
        /// <summary>
        /// Determines whether two rectangles are colliding using axis-aligned bounding box (AABB) collision detection.
        /// Rectangles are defined by their center point, width, and length (height).
        /// </summary>
        /// <param name="rectangular1">The first rectangle. Must not be null.</param>
        /// <param name="rectangular2">The second rectangle. Must not be null.</param>
        /// <returns><see langword="true"/> if the rectangles overlap; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when either rectangle is <see langword="null"/>.</exception>
        public static bool IsCollision(Rectangular rectangular1, Rectangular rectangular2)
        {
            if (rectangular1 == null)
                throw new ArgumentNullException(nameof(rectangular1));
            if (rectangular2 == null)
                throw new ArgumentNullException(nameof(rectangular2));

            double dx = Math.Abs(rectangular1.Center.X - rectangular2.Center.X);
            double dy = Math.Abs(rectangular1.Center.Y - rectangular2.Center.Y);

            double widthSum = (rectangular1.Width + rectangular2.Width) / 2;
            double heightSum = (rectangular1.Length + rectangular2.Length) / 2;

            return dx < widthSum && dy < heightSum;
        }

        /// <summary>
        /// Determines whether two rings (annuli) are colliding by checking distance between centers.
        /// Collision occurs if the distance between centers is less than the sum of external radii.
        /// </summary>
        /// <param name="ring1">The first ring. Must not be null.</param>
        /// <param name="ring2">The second ring. Must not be null.</param>
        /// <returns><see langword="true"/> if the rings overlap; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when either ring is <see langword="null"/>.</exception>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            if (ring1 == null)
                throw new ArgumentNullException(nameof(ring1));
            if (ring2 == null)
                throw new ArgumentNullException(nameof(ring2));

            double dx = ring1.Center.X - ring2.Center.X;
            double dy = ring1.Center.Y - ring2.Center.Y;
            double distance = Math.Sqrt(dx * dx + dy * dy);

            return distance < (ring1.ExternalRadius + ring2.ExternalRadius);
        }
    }
}
