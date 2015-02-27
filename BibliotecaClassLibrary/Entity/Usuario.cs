﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassLibrary.Entity
{
    public class Usuario
    {
        #region campos
        private int idUsuario;
        private string nome;
        private string email;
        private string senha;
        #endregion

        #region propriedades
        public int IdUsuario
        {
            get { return idUsuario; }
            set {idUsuario = value;}
        }

        public string Nome
        {
            get {return nome ;}
            set {nome = value ;}
        }

        public string Email
        {
            get { return email;}
            set { email = value;}
        }

        public string Senha
        {
            get {return senha;}
            set {senha = value;}
        }
        #endregion
    }
}
