using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassLibrary.Entity
{
    public class Categoria
    {
        #region campos
        private int idCategoria;
        private string nome;
        #endregion

        #region propriedades
        public int IdCategoria
        {
            get {return idCategoria ;}
            set { idCategoria = value;}
        }

        public string Nome
        {
            get {return nome ;}
            set {nome = value ;}
        }

        #endregion

    }
}
