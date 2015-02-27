using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BibliotecaClassLibrary.Data
{
    internal class BDConnection
    {
        protected SqlConnection conn;
        internal BDConnection(string strConn)
        {
            conn = new SqlConnection(strConn);
            conn.Open();

        }
        // FECHANDO A CONEXÃO
        internal void Dispose()
        {
            conn.Close();
        }

    }
}
