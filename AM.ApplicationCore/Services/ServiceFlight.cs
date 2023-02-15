using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public List<DateTime> GetFlightDates(string destination)
      {
            List<DateTime> ls = new List<DateTime>();
            for (int j = 0; j < Flights.Count ; j++)

                if (Flights[j].Destination.Equals(destination))
                    ls.Add(Flights[j].FlightDate);
            return ls;
        }
        //foreach
        /*   List<DateTime> ls = new List<DateTime>();
           foreach(Flight f in Flights)
           if (f.Destination.Equals(destination))
           ls.Add(f.FlightDate);
           return ls;*/

        //with LINQ language
        /*var query = from f in Flights
                    where
                    f.Destination.Equals(destination)
                    select f.FlightDate;
            return query.ToList();*/



      
            public void GetFlights(string filterType, string filterValue)
            {
                switch (filterType)
                {
                    case "Destination":
                        foreach (Flight f in Flights)
                        {
                            if (f.Destination.Equals(filterValue))
                                Console.WriteLine(f);
                        }
                        break;
                    case "FlightDate":
                        foreach (Flight f in Flights)
                        {
                            if (f.FlightDate == DateTime.Parse(filterValue))
                                Console.WriteLine(f);
                        }
                        break;
                    case "EffectiveArrival":
                        foreach (Flight f in Flights)
                        {
                            if (f.EffectiveArrival == DateTime.Parse(filterValue))
                                Console.WriteLine(f);
                        }
                        break;
                }
            }



        public void ShowFlightDetails(Plane plane)
        {
            // Requête LINQ pour trouver les vols correspondant à l'avion passé en paramètre
            var query = from flight in Flights
                        where flight.plane == plane
                        select new { flight.FlightDate, flight.Destination }; // Projection anonyme des dates et destinations des vols

            // Parcourir les résultats de la requête et afficher les informations de chaque vol
            foreach (var flight in query)
            {
                // Afficher les informations du vol à l'aide de Console.WriteLine()
                Console.WriteLine("Flight Date: " + flight.FlightDate + ", Flight Destination: " + flight.Destination);
            }
        }



    }



    }

