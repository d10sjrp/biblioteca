using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassLibrary.Entity
{
    public class Livro
    {
        #region campos
        private int idLivro;
        private string titulo;
        private string editora;
        private int idCategoria;
        private int idAluno;
        #endregion

        #region propriedades

        public int IdLivro
        {
            get {return idLivro ;}
            set { idLivro = value;}
        }

        public string Titulo 
        {
            get {return titulo;}
            set { titulo = value; }
        }

        public string Editora
        {
            get { return editora;}
            set { editora = value; }
        }

        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }

        public int IdAluno
        {
            get {return idAluno;}
            set { idAluno = value;}
        }
        #endregion
    }
}
