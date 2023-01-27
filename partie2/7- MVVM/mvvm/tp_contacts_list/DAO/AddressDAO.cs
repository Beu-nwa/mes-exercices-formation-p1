using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using tp_contacts_list.Models;

namespace tp_contacts_list.DAO
{
    internal class AddressDAO : BaseDAO<Address>
    {
        public override int Create(Address element)
        { 
            _connection = Connection.New;// connection à la dbo
            _request = "insert into address_table (number, road, post_code, town, country) output inserted.address_id values (@nb, @rb, @pc, @twn, @ct)"; // préparation de la requete
            _command = new SqlCommand(_request, _connection); // preparation de l'objet sqlcommand
            // ajout des SQL parameters
            _command.Parameters.Add(new SqlParameter("@nb", element.Number));
            _command.Parameters.Add(new SqlParameter("@rb", element.Road));
            _command.Parameters.Add(new SqlParameter("@pc", element.Post_code));
            _command.Parameters.Add(new SqlParameter("@twn", element.Town));
            _command.Parameters.Add(new SqlParameter("@ct", element.Country));
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
            _request = "DELETE FROM Address_Table WHERE address_id = @Tmp_Id;";
            _command = new SqlCommand(_request, _connection);
            _command.Parameters.Add(new SqlParameter("Tmp_Id", id));
            _connection.Open();
            bool deleted = _command.ExecuteNonQuery() > 0;
            _command.Dispose();
            _connection.Close();

            return deleted;
        }

        public override (bool, Address) Find(int index)
        {
            throw new NotImplementedException();
        }

        public (bool, int) Find(Address element)
        {
            bool exist = false;
            _connection = Connection.New;// connection à la dbo
            _request = "SELECT * FROM Address_Table " +
                "WHERE number = @nb " +
                "AND road = @rb " +
                "AND post_code = @pc " +
                "AND town = @twn " +
                "AND country = @ct"; // préparation de la requete
            _command = new SqlCommand(_request, _connection); // preparation de l'objet sqlcommand
            // ajout des SQL parameters
            _command.Parameters.Add(new SqlParameter("@nb", element.Number));
            _command.Parameters.Add(new SqlParameter("@rb", element.Road));
            _command.Parameters.Add(new SqlParameter("@pc", element.Post_code));
            _command.Parameters.Add(new SqlParameter("@twn", element.Town));
            _command.Parameters.Add(new SqlParameter("@ct", element.Country));
            // Ouverture de la connection
            _connection.Open();
            // _reader = _command.ExecuteReader();
            // int id = 0;
            //if (_reader.Read())
            //{
            //    // id = (int)_reader["id"];
            //    id = (int)_command.ExecuteScalar(); // add contact avec adresse deja existante : System.InvalidOperationException : 'There is already an open DataReader associated with this Connection which must be closed first.'
            //    exist = true;
            //}
            if (_reader != null && !_reader.IsClosed)
                _reader.Close();
            _reader = _command.ExecuteReader();
            int id = 0;
            if (_reader.Read())
            {
                id = (int)_reader["address_id"];
                exist = true;
            }
            _reader.Close();
            // liberation de l'objet commande
            _command.Dispose();
            // fermeture de la connection
            // _command.Clone();
            _connection.Close();
            // return de l'id de la personne
            return (exist, id);
        }

        public override void Update(Address element)
        {
            _connection = Connection.New;// connection à la dbo
            _request = "update address_table " +
                "set number = @Tmp_nb, " +
                "road = @Tmp_rd, " +
                "post_code = @Tmp_pc, " +
                "town = @Tmp_tw, " +
                "country = @Tmp_ct " +
                "where address_id = @Tmp_Id";
            _command = new SqlCommand(_request, _connection); // preparation de l'objet sqlcommand
            _command.Parameters.Add(new SqlParameter("Tmp_nb", element.Number));
            _command.Parameters.Add(new SqlParameter("Tmp_rd", element.Road));
            _command.Parameters.Add(new SqlParameter("Tmp_pc", element.Post_code));
            _command.Parameters.Add(new SqlParameter("Tmp_tw", element.Town));
            _command.Parameters.Add(new SqlParameter("Tmp_ct", element.Country));
            _command.Parameters.Add(new SqlParameter("Tmp_Id", element.Address_id));
            _connection.Open();
            _command.ExecuteScalar(); // pb ici
            // int id = (int)_command.ExecuteScalar();
            _command.Dispose();
            _connection.Close();
            // return id;
        }
    
    }
}
