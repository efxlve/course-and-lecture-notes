using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;

namespace ProjectA.Repositories
{
    internal class BaseRepository : IDisposable
    {
        internal SQLiteConnection connection;

        public BaseRepository()
        {
            connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);
            connection.Open();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
