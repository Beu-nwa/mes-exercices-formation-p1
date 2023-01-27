using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using tp_contacts_list.Classes;

namespace tp_contacts_list.DAO
{
    internal class ContactDAO : BaseDAO<Contact>
    {
        public override int Create(Contact element)
        {
            _connection = Connection.New;// connection à la dbo
            _request = "insert into contact_table (person_id, phone_number, email) output inserted.contact_id values (@p_id, @nb, @mail)"; // préparation de la requete
            _command = new SqlCommand(_request, _connection); // preparation de l'objet sqlcommand
            // ajout des SQL parameters
            _command.Parameters.Add(new SqlParameter("@p_id", element.Person_id));
            _command.Parameters.Add(new SqlParameter("@nb", element.Phone_number));
            _command.Parameters.Add(new SqlParameter("@mail", element.Email));
            // Ouverture de la connection
            _connection.Open();
            int id = (int)_command.ExecuteScalar();
            // liberation de l'objet commande
            _command.Dispose();
            // fermeture de la connection
            _command.Clone();
            // return de l'id de la personne
            return id;
        }

        public override bool Delete(int index) // ok
        {
            _connection = Connection.New;
            _request = "DELETE FROM Contact_Table WHERE contact_id = @Tmp_Id;";
            _command = new SqlCommand(_request, _connection);
            _command.Parameters.Add(new SqlParameter("Tmp_Id", index));
            _connection.Open();
            bool deleted = _command.ExecuteNonQuery() > 0;
            _command.Dispose();
            _connection.Close();

            return deleted;
        }

        public override (bool, Contact) Find(int index) // ok mais retourne un contact complet
        {
            Contact contactFounded = null;
            bool found = false;
            _connection = Connection.New;// connection à la dbo
            _request = "select pt.person_id, pt.firstname, pt.lastname, pt.date_of_birth, ct.contact_id, ct.phone_number, ct.email, atb.address_id, atb.number, atb.road, atb.post_code, atb.town, atb.country " +
                "from Contact_Table ct " +
                "inner join Person_Table pt on ct.person_id = pt.person_id " +
                "inner join Contact_Address_Table cat on cat.contact_id = ct.contact_id " +
                "inner join Address_Table atb on atb.address_id = cat.address_id " +
                "where ct.person_id = @Tmp_Id"; // préparation de la requete

            _command = new SqlCommand(_request, _connection); // preparation de l'objet sqlcommand
            _command.Parameters.Add(new SqlParameter("Tmp_Id", index));
            _connection.Open();
            _reader = _command.ExecuteReader();
            if (_reader.Read())
            {
                contactFounded = new Contact()
                {
                    Person_id = _reader.GetInt32(0),
                    Firstname = _reader.GetString(1),
                    Lastname = _reader.GetString(2),
                    Dateofbirth = (DateTime)_reader[3],
                    Contact_id = _reader.GetInt32(4),
                    Contact_address = new Address()
                    {
                        Address_id = _reader.GetInt32(7),
                        Number = _reader.GetString(8),
                        Road = _reader.GetString(9),
                        Post_code = _reader.GetString(10),
                        Town = _reader.GetString(11),
                        Country = _reader.GetString(12)
                    },
                    Phone_number = _reader.GetString(5),
                    Email = _reader.GetString(6)
                };
                found = true;
            }
            _reader.Close();
            _command.Dispose();
            _connection.Close();
            return (found, contactFounded);
        }

        public override void Update(Contact element) // contient son id_address
        {
            _connection = Connection.New;// connection à la dbo
            _request = "update contact_table " +
                "set phone_number = @Tmp_Nb, " +
                "email = @Tmp_Email " +
                "where contact_id = @Tmp_Id";
            _command = new SqlCommand(_request, _connection); // preparation de l'objet sqlcommand
            _command.Parameters.Add(new SqlParameter("Tmp_Nb", element.Phone_number));
            _command.Parameters.Add(new SqlParameter("Tmp_Email", element.Email));
            _command.Parameters.Add(new SqlParameter("Tmp_Id", element.Contact_id));
            _connection.Open();
            _command.ExecuteScalar();
            // int id = (int)_command.ExecuteScalar();
            _command.Dispose();
            _connection.Close();
            // return id;
        }
    }
}
