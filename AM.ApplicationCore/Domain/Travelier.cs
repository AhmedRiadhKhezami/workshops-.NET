using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Travelier : Passenger
    {
        public string HelthInFormation { get; set;}

        public string Nationality { get; set;}

        public override string ToString()
        {
            return "HelthInFormation " + HelthInFormation + " Nationality " + Nationality ;

        }

        public override void PassengerType()
        {
            Console.WriteLine("I am a passenger I am a traveller");
        }
    }
}
