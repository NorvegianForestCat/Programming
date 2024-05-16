using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Services;

namespace Programming.Model
{
    /// <summary>
    /// Store flight info
    /// </summary>
    class Flight
    {
        /// <summary>
        /// Flight fields. Returns and get.
        /// </summary>
        string? _departurePoint;
        string? _destinationPoint;
        int _flightTimeInMinutes;

        /// <summary>
        /// Property DeparturePoint. Returns and get.
        /// </summary>
        public string? DeparturePoint { get; set; }

        /// <summary>
        /// Property DestinationPoint. Returns and get.
        /// </summary>
        public string? DestinationPoint { get; set; }

        /// <summary>
        /// Property FlightTimeInMinutes. Returns and get.
        /// </summary>
        public int FlightTimeInMinutes
        {
            get
            {
                return _flightTimeInMinutes;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Flight time in minutes");
                _flightTimeInMinutes = value;
            }
        }

        /// <summary>
        /// Constructor without args
        /// </summary>
        public Flight()
        {
            DestinationPoint = "PL/Lodz";
            DeparturePoint = "RU/Novosibirsk";
            FlightTimeInMinutes = 306;
        }

        /// <summary>
        /// Contructor with args
        /// </summary>
        /// <param name="departurePoint">String</param>
        /// <param name="destinationPoint">String</param>
        /// <param name="flightTimeInMinutes">int</param>
        public Flight(string? departurePoint, string? destinationPoint, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightTimeInMinutes = flightTimeInMinutes;
        }
    }
}
