using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using tp_contacts_list.Classes;

namespace tp_contacts_list.DAO
{
    internal class PersonDAO : BaseDAO<Person>
    {
        public override int Create(Person element)
        {
            _connection = Connection.New;// connection à la dbo
            _request = "insert into person_table (firstname, lastname, date_of_birth) output inserted.person_id values (@fn, @ln, @dob)"; // préparation de la requete
            _command = new SqlCommand(_request, _connection); // preparation de l'objet sqlcommand
            // ajout des SQL parameters
            _command.Parameters.Add(new SqlParameter("@fn", element.Firstname));
            _command.Parameters.Add(new SqlParameter("@ln", element.Lastname));
            _command.Parameters.Add(new SqlParameter("@dob", element.Dateofbirth));
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

        public override bool Delete(int id)
        {
            _connection = Connection.New;
            _request = "DELETE FROM Person_Table WHERE person_id = @Tmp_Id;";
            _command = new SqlCommand(_request, _connection);
            _command.Parameters.Add(new SqlParameter("Tmp_Id", id));
            _connection.Open();
            bool deleted = _command.ExecuteNonQuery() > 0;
            _command.Dispose();
            _connection.Close();

            return deleted;
        }

        public override (bool, Person) Find(int index)
        {
            throw new NotImplementedException();
        }

        public override void Update(Person element)
        {
            _connection = Connection.New;// connection à la dbo
            _request = "update person_table " +
                "set firstname = @Tmp_fn, " +
                "lastname = @Tmp_ln " +
                "where person_id = @Tmp_Id";
            _command = new SqlCommand(_request, _connection); // preparation de l'objet sqlcommand
            _command.Parameters.Add(new SqlParameter("Tmp_fn", element.Firstname));
            _command.Parameters.Add(new SqlParameter("Tmp_ln", element.Lastname));
            _command.Parameters.Add(new SqlParameter("Tmp_Id", element.Person_id));
            _connection.Open();
            _command.ExecuteScalar();
            // int id = (int)_command.ExecuteScalar();
            _command.Dispose();
            _connection.Close();
            // return id;
        }
    }
}
