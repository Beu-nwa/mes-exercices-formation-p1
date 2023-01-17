using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpContacts.Classes
{
    public class Address
    {
        // private static int address_id = 0;
        private int address_id;
        private string? number;
        private string? road;
        private string? post_code;
        private string? town;
        private string? country;

        public int Address_id { get => address_id; set => address_id = value; }
        public string? Number { get => number; set => number = value; }
        public string? Road { get => road; set => road = value; }
        public string? Post_code { get => post_code; set => post_code = value; }
        public string? Town { get => town; set => town = value; }
        public string? Country { get => country; set => country = value; }

        public Address()
        {

        }
        public Address(int id, string number, string road, string postCode, string town, string country) // la data existe deja, on entre son id
        {
            address_id = id;
            this.number = number;
            this.road = road;
            post_code = postCode;
            this.town = town;
            this.country = country;
        }
        public Address(string number, string road, string postCode, string town, string country)
        {
            this.number = number;
            this.road = road;
            post_code = postCode;
            this.town = town;
            this.country = country;
        }
        public override string ToString()
        {
            return $"Adresse : {number} {road} {post_code} {town} {country}";
        }
    }
}
