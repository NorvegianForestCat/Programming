using Programming.Model.Services;

namespace Programming.Model
{
    /// <summary>
    /// Represents a flight with departure point, destination, and duration.
    /// </summary>
    public class Flight : IEquatable<Flight>
    {
        private string? _departurePoint;
        private string? _destinationPoint;
        private int _flightTimeInMinutes;

        /// <summary>
        /// Gets or sets the departure point of the flight (e.g., "RU/Novosibirsk").
        /// Can be <see langword="null"/> or empty.
        /// </summary>
        /// <value>A string representing the origin location, optionally including country code.</value>
        public string? DeparturePoint
        {
            get => _departurePoint;
            set => _departurePoint = value;
        }

        /// <summary>
        /// Gets or sets the destination point of the flight (e.g., "PL/Lodz").
        /// Can be <see langword="null"/> or empty.
        /// </summary>
        /// <value>A string representing the destination location, optionally including country code.</value>
        public string? DestinationPoint
        {
            get => _destinationPoint;
            set => _destinationPoint = value;
        }

        /// <summary>
        /// Gets or sets the duration of the flight in minutes. Must be a positive integer.
        /// </summary>
        /// <value>An integer representing flight time in minutes (e.g., 306).</value>
        /// <exception cref="ArgumentException">
        /// Thrown when the value is less than or equal to zero.
        /// </exception>
        public int FlightTimeInMinutes
        {
            get => _flightTimeInMinutes;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(FlightTimeInMinutes));
                _flightTimeInMinutes = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Flight"/> class with default values.
        /// </summary>
        public Flight()
        {
            DeparturePoint = "RU/Novosibirsk";
            DestinationPoint = "PL/Lodz";
            FlightTimeInMinutes = 306;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Flight"/> class with specified parameters.
        /// </summary>
        /// <param name="departurePoint">The departure location (e.g., "RU/Moscow"). Can be <see langword="null"/>.</param>
        /// <param name="destinationPoint">The destination location (e.g., "FR/Paris"). Can be <see langword="null"/>.</param>
        /// <param name="flightTimeInMinutes">The duration of the flight in minutes. Must be greater than zero.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="flightTimeInMinutes"/> is not a positive value.
        /// </exception>
        public Flight(string? departurePoint, string? destinationPoint, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightTimeInMinutes = flightTimeInMinutes;
        }

        /// <summary>
        /// Returns a string representation of the flight in format: "Departure → Destination (Time min)".
        /// </summary>
        /// <returns>A human-readable string describing the flight route and duration.</returns>
        public override string ToString()
        {
            return $"{DeparturePoint} → {DestinationPoint} ({FlightTimeInMinutes} min)";
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="Flight"/> instance.
        /// </summary>
        /// <param name="obj">The object to compare with this instance.</param>
        /// <returns><see langword="true"/> if the objects are equal; otherwise, <see langword="false"/>.</returns>
        public override bool Equals(object? obj) => Equals(obj as Flight);

        /// <summary>
        /// Determines whether the specified <see cref="Flight"/> is equal to the current instance.
        /// </summary>
        /// <param name="other">The <see cref="Flight"/> to compare with this instance.</param>
        /// <returns>
        /// <see langword="true"/> if both flights have identical departure, destination, and duration; otherwise, <see langword="false"/>.
        /// </returns>
        public bool Equals(Flight? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return DeparturePoint == other.DeparturePoint &&
                   DestinationPoint == other.DestinationPoint &&
                   FlightTimeInMinutes == other.FlightTimeInMinutes;
        }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for this instance.</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(DeparturePoint, DestinationPoint, FlightTimeInMinutes);
        }
    }
}