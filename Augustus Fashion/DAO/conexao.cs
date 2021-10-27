using System.Data;
using System.Data.SqlClient;

namespace Augustus_Fashion.DAO
{

    class conexao
    {
        const string connString =
        @"Data Source=DESKTOP-DSMAB0L;Initial Catalog=crud;Integrated Security=True";

        public static SqlConnection conn = null;

        public IDbConnection Connection() =>
            new SqlConnection(connString);
    }
}
