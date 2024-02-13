using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Flight
    {
        string? departurePoint;
        string? destinationPoint;

        int flightTimeInMinutes;

        public string? DeparturePoint { get; set; }
        public string? DestinationPoint { get; set; }        

        public int FlightTimeInMinutes
        {
            get
            {
                return FlightTimeInMinutes;
            }
            set
            {
                if (value > 0)
                {
                    flightTimeInMinutes = value;
                }
                else
                {
                    throw new ArgumentException("Flight time must be greater than 0 minutes");
                }
            }
        }

        public Flight(string? departurePoint, string? destinationPoint, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;

            FlightTimeInMinutes = flightTimeInMinutes;
        }
    }
}
