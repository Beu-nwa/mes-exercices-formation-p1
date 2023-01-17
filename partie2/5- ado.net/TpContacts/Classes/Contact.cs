using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpContacts.Classes
{
    public class Contact : Person
    {
        private int contact_id;
        private Address contact_address;
        private string phone_number;
        private string email;
        public int Contact_id { get => contact_id; set => contact_id = value; }
        public Address Contact_address { get => contact_address; set => contact_address = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
        public string Email { get => email; set => email = value; }

        public Contact()
        {

        }
        //public Contact(string firstname, string lastname, DateTime dateofbirth, string tel, string email) : base(firstname, lastname, dateofbirth)
        //{
        //    phone_number = tel;
        //    this.email = email;
        //}
        //public Contact(int id, string firstname, string lastname, DateTime dateofbirth, string tel, string email) : base(firstname, lastname, dateofbirth) // la data existe deja, on peut entrer son id
        //{
        //    contact_id = id;
        //    phone_number = tel;
        //    this.email = email;
        //}
        public Contact(string firstname, string lastname, DateTime dateofbirth, Address address, string tel, string email) : base(firstname, lastname, dateofbirth)
        {
            contact_address = address;
            phone_number = tel;
            this.email = email;
        }
        public Contact(int p_id, int c_id, string firstname, string lastname, DateTime dateofbirth, Address address, string tel, string email) : base(firstname, lastname, dateofbirth) // la data existe deja, on peut entrer son id
        {
            Person_id= p_id;
            contact_id = c_id;
            contact_address = address;
            phone_number = tel;
            this.email = email;
        }
        public override string ToString()
        {
            return $"contact : {Firstname} {Lastname}, contactid : {contact_id}, Personid : {Person_id}.";
        }
    }
}
