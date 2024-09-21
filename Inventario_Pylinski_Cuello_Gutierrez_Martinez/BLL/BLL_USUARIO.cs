using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class BLL_USUARIO
    {
        DAL_USUARIO dal = new DAL_USUARIO();


        public BE_USUARIO Recuperarusuario(string usuario)
        {
            return dal.Recuperarusuario(usuario);
        }
        public bool Validar(BE_USUARIO usuario)
        {
            return dal.Validar(usuario);
        }

        #region ----------------------------------------------------------------------------------- No se usa

        public List<BE_USUARIO> Devolverusuarios()
        {
            return dal.Devolverusuarios();
        }
        public BE_USUARIO Recuperarusuario(int usuario)
        {
            return dal.Recuperarusuario(usuario);
        }
        
        public bool Verificarexistenciausuario(BE_USUARIO usuario)
        {
            return dal.Verificarexistenciausuario(usuario);

        }
        
        public List<BE_USUARIO> Devolverusuariosmenosactual(string usuario)
        {

            return dal.Devolverusuariosmenosactual(usuario);
        }

        #endregion 
    }
}
