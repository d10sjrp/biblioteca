using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BibliotecaClassLibrary.Entity;

namespace BibliotecaClassLibrary.Data
{
    internal class AutorData : BDConnection
    {
        // CONSTRUTOR QUE CHAMA A SUPERCLASSE BDCONNECTION
        internal AutorData(string strConn) : base(strConn) { }

        // CRIANDO O MÉTODO CREATE(INSERT)
        internal void CREATE(Autor e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Autor values (@nome)";
            cmd.Parameters.AddWithValue("@Nome",e.Nome);            
            cmd.ExecuteNonQuery();
        }

        // CRIANDO O MÉTODO UPDATE
        internal void UPDATE(Autor e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Autor set nome = @nome where IdAutor = @IdAutor ";
            cmd.Parameters.AddWithValue("@nome",e.Nome);
            cmd.Parameters.AddWithValue("@IdAutor", e.IdAutor);
            cmd.ExecuteNonQuery();
        }

    }
}
