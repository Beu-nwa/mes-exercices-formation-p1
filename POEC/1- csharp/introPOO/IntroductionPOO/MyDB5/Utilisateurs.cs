using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyDB5
{
    internal class Utilisateurs
    {
        private int id;
        private string login;
        private string password;
        private MD5 md5Hash;

        public Utilisateurs()
            {
                
            }

        public Utilisateurs(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }

        public (bool, int) Add()
        {
            SqlConnection connection = Connection.New;
            string request = "insert into utilsateur (login, password,) output inserted.id values (@login, @password)";
            SqlCommand command = connection.CreateCommand();
            md5Hash = MD5.Create();
            //string MdpHashed = MyMD5.GetMd5Hash(md5Hash, Password);
            command.Parameters.Add(new SqlParameter("@login", login));
            //command.Parameters.Add(new SqlParameter("@password", MdpHashed));
            connection.Open();
            command.ExecuteScalar();
            int Id = (int)command.ExecuteScalar();
            connection.Dispose();
            connection.Close();
            return (Id > 0, Id);
        }
    }
}
