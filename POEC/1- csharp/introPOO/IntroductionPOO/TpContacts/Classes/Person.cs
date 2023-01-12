using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpContacts.Classes
{
    public class Person
    {
        // private static int person_id = 0;
        private int person_id;
        private string firstname;
        private string lastname;
        private DateTime date_of_birth;
        public int Person_id { get => person_id; set => person_id = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public DateTime Dateofbirth { get => date_of_birth; set => date_of_birth = value; }

        public Person() { }
        public Person(string firstname, string lastname, DateTime dateofbirth)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            date_of_birth = dateofbirth;
        }
        public Person(int id, string firstname, string lastname, DateTime dateofbirth) // lorsque la data existe déja elle a déja un id et il faut donc le mettre dans le constructeur
        {
            person_id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            date_of_birth = dateofbirth;
        }
        public override string ToString()
        {
            return $"personne : {firstname} {lastname}, id : {person_id}";
        }
    }
}
