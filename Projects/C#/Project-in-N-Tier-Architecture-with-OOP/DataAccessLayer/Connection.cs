using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Connection
    {
        public static SqlConnection sqlConnection = new SqlConnection(@"Data Source=SERVERNAME;Initial Catalog=DbEmployee;Integrated Security=True");
    }
}
