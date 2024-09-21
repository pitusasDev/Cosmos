using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BE
{
    public class BE_USUARIO
    {
        private string usuario;
        private string contra;
      public List<BE_MENSAJE> Mymensajes = new List<BE_MENSAJE>();

        public BE_USUARIO()
        {

        }
        public BE_USUARIO(string usuario, string contra)
        {
            this.usuario =usuario.Trim();
            this.contra = contra.Trim();
        }

        public string Contra
        {
            get { return contra; }
            set { contra = value; }
        }



        public string Myuser
        {
            get { return usuario; }
            set { usuario = value; }
        }
    }
}