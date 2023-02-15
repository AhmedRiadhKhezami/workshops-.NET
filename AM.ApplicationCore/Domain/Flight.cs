using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string Destination { get; set; }
        public string Departure { get; set; }

        public string FlightId { get; set; }

        public DateTime FlightDate { get; set;}

        public DateTime EffectiveArrival { get; set; }

        public int EstimateDuration { get;set; }

        public IList<Passenger> Passengers { get; set; }

        public Plane plane { get; set; }


        public override string ToString()
        {
            return "flight id : " + FlightId + " date of flight: " + FlightDate + " Effective Arrival: " + EffectiveArrival +
                "Estimate Duration" + EstimateDuration;
        }


    }
}
