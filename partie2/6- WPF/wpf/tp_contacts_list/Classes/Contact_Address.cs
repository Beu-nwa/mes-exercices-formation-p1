using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_contacts_list.Classes
{
    public class Contact_Address
    {
        private int contact_id;
        private int address_id;

        public Contact_Address()
        {

        }
        public Contact_Address(int contactId, int addId) 
        {
            contact_id = contactId;
            address_id = addId;
        }

        public int Contact_id { get => contact_id; set => contact_id = value; }
        public int Address_id { get => address_id; set => address_id = value; }
    }
}
