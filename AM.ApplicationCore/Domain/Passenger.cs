using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public int PassportNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string EmailAdress { get; set; }
        public int TelNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "password number " + PassportNumber + " birth day: " + BirthDate + " adress mail " + EmailAdress +
                "telephone number " + TelNumber + "FirstName" + FirstName + "LastName " + LastName;

        }


        

        public bool checkProfile(string firstName, string lastName, string email ="")
        {
            if (string.IsNullOrEmpty(email))
            {
                return FirstName == firstName && LastName == lastName;
            }
            else
            {
                return FirstName == firstName && LastName == lastName && EmailAdress == email;
            }
        }



        public virtual void PassengerType()
        {
            Console.WriteLine("i am a passenger");
        }





    }
}
