using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_MENSAJES:DAL
    {

        public List<BE_MENSAJE> Devolvertodosmensajes()
        {
            List<BE_MENSAJE> mensajes = new List<BE_MENSAJE>();
            DAL_USUARIO du = new DAL_USUARIO();

            DataSet ds = DevolverDataset("SELECT * FROM MENSAJE;");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                BE_MENSAJE obj = new BE_MENSAJE();
                obj.Myid = Convert.ToInt32(dr[0]);
                obj.MyUsuariodestino = du.Recuperarusuarioporid(Convert.ToInt32(dr[1]));
                obj.Myusuarioorigen = du.Recuperarusuarioporid(Convert.ToInt32(dr[2]));
                obj.MyContenido = dr[3].ToString();
                mensajes.Add(obj);

            }
            return mensajes;
        }
        public BE_MENSAJE Devolvermensaje(int id)
        {
            DataSet ds = DevolverDataset("SELECT * FROM MENSAJE;");
            BE_MENSAJE obj = new BE_MENSAJE();
            DAL_USUARIO du = new DAL_USUARIO();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (Convert.ToInt32(dr[0]) == id)
                {
                    BE_USUARIO userorigen = new BE_USUARIO();
                    BE_USUARIO userdestino = new BE_USUARIO();

                    obj.Myid = Convert.ToInt32(dr[0]);
                    obj.MyUsuariodestino = du.Recuperarusuarioporid(Convert.ToInt32(dr[1]));
                    obj.Myusuarioorigen = du.Recuperarusuarioporid(Convert.ToInt32(dr[2]));
                    obj.MyContenido = dr[3].ToString();
                }
            }
            return obj;

        }
        public bool Guardarmensaje(BE_MENSAJE mensaje)
        {

            DAL_USUARIO du = new DAL_USUARIO();

            return Execute("INSERT INTO MENSAJE(Usuariodestino,Usuarioorigen,Mensaje) VALUES " + du.RecuperarusuarioID(mensaje.MyUsuariodestino) + "," + du.RecuperarusuarioID(mensaje.MyUsuariodestino) + ",'" + mensaje.MyContenido + "';");
        }
        public List<BE_MENSAJE> Devolvermensajesdeusuarios(string usuarioorigen, string usuariodestino)
        {
            DataSet ds = DevolverDataset("SELECT * FROM MENSAJE;");
            List<BE_MENSAJE> msj = new List<BE_MENSAJE>();



            DAL_USUARIO du = new DAL_USUARIO();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                BE_USUARIO userorigen = new BE_USUARIO();
                BE_USUARIO userdestino = new BE_USUARIO();
                userdestino = du.Recuperarusuario(Convert.ToInt32(dr[1]));
                if (usuarioorigen == userorigen.Myuser && usuariodestino == userdestino.Myuser)
                {
                    BE_MENSAJE obj = new BE_MENSAJE();
                    userorigen = du.Recuperarusuario(Convert.ToInt32(dr[2]));

                    obj.Myid = Convert.ToInt32(dr[0]);
                    obj.MyUsuariodestino = userdestino.Myuser;
                    obj.Myusuarioorigen = userdestino.Myuser;
                    obj.MyContenido = dr[3].ToString();

                    msj.Add(obj);
                }

            }
            return msj;

        }
        public List<BE_MENSAJE> Devolvermensajesdeusuario(string usuarioorigen)
        {
            List<BE_MENSAJE> msj = Devolvertodosmensajes();
            List<BE_MENSAJE> msjs = new List<BE_MENSAJE>();
            DAL_USUARIO du = new DAL_USUARIO();

            msj.ForEach((BE_MENSAJE m) => {
                if (m.Myusuarioorigen == usuarioorigen)
                {
                    msjs.Add(m);
                }

            });


            return msjs;

        }

    }
}
