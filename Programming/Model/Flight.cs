using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Services;

namespace Programming.Model
{
    class Flight
    {
        string? _departurePoint;
        string? _destinationPoint;
        int _flightTimeInMinutes;

        // string DeparturePoint, any string values
        public string? DeparturePoint { get; set; }
        // string DestinationPoint, any string values
        public string? DestinationPoint { get; set; }

        // int FlightTimeInMinutes, int value above 0. In another cases - ArgumentException
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

        // Base constructor without arguments
        public Flight()
        {
            DestinationPoint = "PL/Lodz";
            DeparturePoint = "RU/Novosibirsk";
            FlightTimeInMinutes = 306;
        }

        // Constructor with arguments
        public Flight(string? departurePoint, string? destinationPoint, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightTimeInMinutes = flightTimeInMinutes;
        }
    }
}
