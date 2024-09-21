using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace SERVICIOS
{
    public class SESION
    {
        public BE_USUARIO usuario { get; set; }
        private static SESION sesion;


        public static SESION ObtenerInstancia
        {
            get
            {
                //if (sesion == null) throw new Exception("Sesion no iniciada");
                return sesion;
            }
        }
        public static bool Login(BE_USUARIO usuario)
        {
            if (sesion == null)
            {
                sesion = new SESION();
                sesion.usuario = usuario;
                return true;
            } 
            else
            {
                //throw new Exception("Sesion ya iniciada");
                return false;

            }

        }
        public static bool Logout()
        {
            if (sesion != null)
            {
                sesion = null;
                return true;
            } else
            {
                throw new Exception("Sesion no iniciada");
            }

        }

    }
}
