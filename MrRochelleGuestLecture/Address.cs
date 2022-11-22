using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRochelleGuestLecture
{
    public class Address
    {
        public Address()
        {
            //do nothing!
        }
        public Address(Address otherObj)
        {
            StreetNumber = otherObj.StreetNumber;
            City = otherObj.City;
            StreetName = otherObj.StreetName;
            State = otherObj.State;
            ZipCode = otherObj.ZipCode;
        }

        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }



  

        public override string ToString()
        {
            string msg = "";

            msg += $"{StreetNumber} {StreetName} \n";
            msg += $"{City}, {State} {ZipCode}";

            return msg;
        }
    }
}
