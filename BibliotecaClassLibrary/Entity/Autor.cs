using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassLibrary.Entity
{
    public class Autor
    {
        #region campos
        private int idAutor;
        private string nome;
        #endregion

        #region propriedades
        public int IdAutor
        {
            get {return idAutor;}
            set { idAutor = value; }
        }
        #endregion

        public string Nome
        {
            get {return nome ;}
            set { nome = value; }
        }

    }
}
