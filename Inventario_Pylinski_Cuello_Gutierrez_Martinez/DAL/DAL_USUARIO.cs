using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_USUARIO:DAL
    {


        public List<BE_USUARIO> Devolverusuarios()
        {
            DataSet ds = DevolverDataset("SELECT * FROM USUARIO;");
            //DAL_MENSAJES dm = new DAL_MENSAJES();

            List<BE_USUARIO> usuarios = new List<BE_USUARIO>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                BE_USUARIO user = new BE_USUARIO(row[3].ToString(), row[4].ToString());
              //  user.Mymensajes = dm.Devolvermensajesdeusuario(user.Myuser);
                usuarios.Add(user);



            }
            return usuarios;
        }
        public List<BE_USUARIO> Devolverusuariosmenosactual(string usuario)
        {
            DataSet ds = DevolverDataset("SELECT * FROM USUARIO;");
            List<BE_USUARIO> usuarios = new List<BE_USUARIO>();
          //  DAL_MENSAJES dm = new DAL_MENSAJES();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (row[1].ToString() != usuario)
                {
                    BE_USUARIO user = new BE_USUARIO(row[1].ToString(), row[2].ToString());
                   //user.Mymensajes = dm.Devolvermensajesdeusuario(user.Myuser);
                    usuarios.Add(user);


                }

            }
            return usuarios;
        }
        public BE_USUARIO Recuperarusuario(string usuario)
        {
            List<BE_USUARIO> lista = Devolverusuarios();
            BE_USUARIO user = new BE_USUARIO();
            lista.ForEach((BE_USUARIO u) => {

                 if (u.Myuser == usuario)
                {
                    user = u;

                }
                
            });
            return user;
        }
        public string Recuperarusuarioporid(int id)
        {
            string consulta = "SELECT Usuario FROM USUARIO WHERE Id = " + id + ";";
            Conectar();
            cmd = new SqlCommand(consulta, conn);

            object usuario = cmd.ExecuteScalar();
            Desconectar();
            return usuario.ToString();
        }

        public BE_USUARIO Recuperarusuario(int id)
        {
            DataSet ds = DevolverDataset("SELECT * FROM USUARIO;");
            BE_USUARIO user = new BE_USUARIO();
           // DAL_MENSAJES dm = new DAL_MENSAJES();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (Convert.ToInt32(row[0]) == id)
                {
                    user = new BE_USUARIO(row[1].ToString(), row[2].ToString());
                  //  user.Mymensajes = dm.Devolvermensajesdeusuario(user.Myuser);
                }
            }
            return user;
        }

        public int RecuperarusuarioID(string usuario)
        {
            int id = 0; // Inicializa el id
            string consulta = "SELECT Id FROM USUARIO WHERE Usuario = '" + usuario + "';";
            cmd = new SqlCommand(consulta, conn);

            Conectar();
            object result = cmd.ExecuteScalar();//ejecutar una consulta SQL y devolver el valor de la primera columna de la primera fila del conjunto de resultados, así que será el Id

            if (result != null)
            {
                id = Convert.ToInt32(result); // Convierte el resultado a int si no es nulo
            }
            Desconectar();


            return id; // Devuelve el id
        }

        public bool Verificarexistenciausuario(BE_USUARIO usuario)
        {

            List<BE_USUARIO> lista = Devolverusuarios();

            BE_USUARIO user = new BE_USUARIO();
            bool f = lista.Any(becli => usuario.Myuser == usuario.Myuser);
            return f;

        }
        public bool Validar(BE_USUARIO usuario)
        {
            if (Verificarexistenciausuario(usuario))
            {
                if (Recuperarusuario(usuario.Myuser).Contra == usuario.Contra)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("La contraseña ingresada fue incorrecta.");
                    return false;
                }

            }
            else
            {
                MessageBox.Show("No existe el usuario indicado.");
                return false;
            }
        }

        //////////////////////////
    }
}
