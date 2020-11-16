using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMTWebAPI.DataServices
{
    public class SqlRepository : IDisposable
    {
        protected readonly SqlConnection _conn;

        public SqlRepository(string connectionString)
        {
            _conn = new SqlConnection(connectionString);
            _conn.Open();
        }

        public void Dispose()
        {
            _conn.Dispose();
        }
    }
}
