using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp_contacts_list.Models;
using System.Reflection;

namespace tp_contacts_list.DAO
{
    internal class Contact_Address_DAO : BaseDAO<Contact_Address>
    {
        public void Create(int cid, int aid)
        {
            _connection = Connection.New;// connection à la dbo
            _request = "insert into contact_address_table (contact_id, address_id) output inserted.contact_address_id values (@c_id, @a_id)"; // préparation de la requete
            _command = new SqlCommand(_request, _connection); // preparation de l'objet sqlcommand
            // ajout des SQL parameters
            _command.Parameters.Add(new SqlParameter("@c_id", cid));
            _command.Parameters.Add(new SqlParameter("@a_id", aid));
            // Ouverture de la connection
            _connection.Open();
            _command.Dispose();
            _command.Clone();
        }

        public override int Create(Contact_Address element)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int id)
        {
            _connection = Connection.New;
            _request = "DELETE FROM Contact_Address_Table WHERE contact_id = @Tmp_Id;";
            _command = new SqlCommand(_request, _connection);
            _command.Parameters.Add(new SqlParameter("Tmp_Id", id));
            _connection.Open();
            bool deleted = _command.ExecuteNonQuery() > 0;
            _command.Dispose();
            _connection.Close();

            return deleted;
        }

        public override (bool, Contact_Address) Find(int index)
        {
            throw new NotImplementedException();
        }

        public override void Update(Contact_Address element)
        {
            _connection = Connection.New;// connection à la dbo
            _request = "update contact_address_table " +
                "set address_id = @Tmp_Ad_Id " +
                "where contact_id = @Tmp_c_Id";
            _command = new SqlCommand(_request, _connection); // preparation de l'objet sqlcommand
            _command.Parameters.Add(new SqlParameter("Tmp_Ad_Id", element.Address_id));
            _command.Parameters.Add(new SqlParameter("Tmp_c_Id", element.Contact_id));
            _connection.Open();
            _command.ExecuteScalar();
            // int id = (int)_command.ExecuteScalar();
            _command.Dispose();
            _connection.Close();
            // return id;
        }

        public int Count(int address_id)
        {
            _connection = Connection.New;
            _request = "SELECT COUNT(contact_id) " +
                       "FROM Contact_Address_Table " +
                       "where address_id = @Tmp_Id ";
            _command = new SqlCommand(_request, _connection);
            _command.Parameters.Add(new SqlParameter("Tmp_Id", address_id));
            _connection.Open();
            int nb_bind_contact = (int)_command.ExecuteScalar();
            _command.Dispose();
            _connection.Close();
            return nb_bind_contact;
        }
    }
}
