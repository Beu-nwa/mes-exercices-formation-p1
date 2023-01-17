using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MyEnvironement.Classes
{
    internal class HouseAddress : Address
    {
        public HouseAddress(int id, int homeNumber, string roadName, int zipCode, string city, string state, string country)
        {
            Id = id;
            HomeNumber = homeNumber;
            RoadName = roadName;
            ZipCode = zipCode;
            City = city;
            State = state;
            Country = country;
        }

        public override string ToString()
        {
            return $"Address: \n\t{HomeNumber} {RoadName}" +
                $"\n\t{ZipCode} {City}" +
                $"\n\t{State} - {Country}";
        }
    }
}
