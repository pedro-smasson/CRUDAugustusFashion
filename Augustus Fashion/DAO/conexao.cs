using Augustus_Fashion.Controller;
using Augustus_Fashion.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
