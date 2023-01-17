using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpContacts
{
    public class Connection
    {
        private static string connectionString = @"Data Source=(LocalDb)\Tp_list_contact;Integrated Security=True";
        public static SqlConnection New
        {
            get => new SqlConnection(connectionString);
        }
    }
}
