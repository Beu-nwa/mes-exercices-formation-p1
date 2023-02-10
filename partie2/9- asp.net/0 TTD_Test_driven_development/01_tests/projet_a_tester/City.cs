using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_a_tester
{
    public class City
    {
        private List<string> cities;
        public List<string> Cities { get => cities; set => cities = value; }
        public City()
        {
            Cities = new List<string>() { "Paris", "Budapest", "Skopje",
                "Rotterdam", "Valence", "Vancouver", "Amsterdam", "Vienne",
                "Sydney", "New York", "Londres", "Bangkok", "Hong Kong",
                "Dubaï", "Rome", "Istanbul" };
        }
        public List<string> Rechercher(string c)
        {
            if (c.Length < 2)
            {
                if(c == "*")
                {
                    return Cities;
                }
                throw new NotFoundException();
            }
            else
            {
                return Cities.Where(city => city.ToLower().Contains(c.ToLower())).ToList();
            }
        }
    }
}
