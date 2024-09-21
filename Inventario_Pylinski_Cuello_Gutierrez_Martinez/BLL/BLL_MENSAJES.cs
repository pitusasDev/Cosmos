using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class BLL_MENSAJES
    {
        DAL_MENSAJES dal = new DAL_MENSAJES();
        public List<BE_MENSAJE> Devolvertodosmensajes()
        {
            return dal.Devolvertodosmensajes();
        }
        public BE_MENSAJE Devolvermensaje(int id)
        {
            return dal.Devolvermensaje(id);
        }
        public List<BE_MENSAJE> Devolvermensajesdeusuarios(string usuarioorigen, string usuariodestino)
        {
            return dal.Devolvermensajesdeusuarios(usuarioorigen, usuariodestino);
        }
        public bool Guardarmensaje(BE_MENSAJE mensaje)
        {
            return dal.Guardarmensaje(mensaje);
        }
    }
}
