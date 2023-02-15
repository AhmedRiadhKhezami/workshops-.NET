using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{


    public enum PlaneType
    {
        Boing,
        Airbus

    }
    public class Plane
    {

        public int? Capacity { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public int? PlaneId { get; set; }
        public PlaneType PlaneType { get; set;}

       public virtual IList<Flight> Flights { get; set; }


        public Plane()
        {
        }

        public override string ToString()
        {
            
            return 
                  "Capacity"
                + Capacity
                + "ManufactureDate"
                + ManufactureDate
                + "id plane"
                + PlaneId
                + "typeplane"
                + PlaneType;
        }

        public static implicit operator Plane(Plane v)
        {
            throw new NotImplementedException();
        }
    }
    
}
