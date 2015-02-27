using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BibliotecaClassLibrary.Entity;

namespace BibliotecaClassLibrary.Data
{
    internal class CategoriaData : BDConnection
    {
        // CONTRUTOR QUE CHAMA A SUPERCLASSE BDCONNECTION
        internal CategoriaData(string strConn) : base(strConn) { }

        // CRIANDO O MÉTODO CREATE OU INSERT
        internal void CREATE(Categoria e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText =  "INSERT INTO Categorias VALUES (@nome)";
            cmd.Parameters.AddWithValue("@nome", e.Nome);
            cmd.ExecuteNonQuery();
        }

        // CRIANDO O MÉTODO UPDATE
        internal void UPDATE(Categoria e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Categorias set nome = @nome where Idcategoria = @Idcategoria";
            cmd.Parameters.AddWithValue("@nome", e.Nome);
            cmd.Parameters.AddWithValue("@IdCategoria", e.IdCategoria);
            cmd.ExecuteNonQuery();
        }

    }
}
