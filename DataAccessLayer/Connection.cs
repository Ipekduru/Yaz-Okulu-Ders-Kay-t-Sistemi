using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class Connection
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=LAPTOP-OEJARLBE\MSSQLSERVER01;Initial Catalog=DbYazOkulu;Integrated Security=True");
    }
}