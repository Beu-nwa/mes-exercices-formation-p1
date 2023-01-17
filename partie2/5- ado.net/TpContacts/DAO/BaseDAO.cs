using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TpContacts.DAO
{
    public abstract class BaseDAO<T>
    {
        protected static SqlCommand _command;
        protected static SqlConnection _connection;
        protected static SqlDataReader _reader;
        protected static string _request;

        public abstract int Create(T element); // generique donc peut être de tout type (person, contact, address)

        public abstract bool Delete(int id);

        public abstract void Update(T element);

        public abstract (bool, T) Find(int index);

        // public abstract (bool, int) Find(T element);

        // public abstract void Create(int a, int b);

        // public abstract int Count(int id);

        // public abstract bool Delete(T element);

        // public abstract (bool, List<T>) Find(Func<T, bool> critere); // methode avec signature generique sous forme de liste et un delegate
        
        // public abstract List<T> Find_all(); // methode avec signature generique sous forme de liste et un delegate
    }
}
