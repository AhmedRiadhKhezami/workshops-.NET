using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff : Passenger
    {
        public DateTime  EmployementDate { get; set; }
        public string Fonction { get; set; }
        public float Salary { get; set; }

        public override string ToString()
        {
            return "date d'employment " + EmployementDate + " Fonction " + Fonction + "Salary" + Salary;

        }

        public override void PassengerType()
        {
            Console.WriteLine("I am a passenger I am a Staff");
        }

        public static implicit operator Staff(Staff v)
        {
            throw new NotImplementedException();
        }
    }
}
