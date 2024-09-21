using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using SERVICIOS;
using System.Data.SqlClient;
using System.Threading;
using static System.Collections.Specialized.BitVector32;

namespace Inventario_Pylinski_Cuello_Gutierrez_Martinez
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
            TXTname.Text = "chriis";
            TXTcontraseña.Text = "asd";
        }

        BLL_USUARIO blluser = new BLL_USUARIO();
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pcbRetroceder1_Click(object sender, EventArgs e)
        {
            if (SESION.ObtenerInstancia != null)
            {
                var th = new Thread(() => Application.Run(new Inicio()));
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();
            }

            /* ---------------------------------------------------------------------------------------------------------BORRAR
             * 
            DialogResult result = MessageBox.Show("¿Realmente quieres cerrar sesion?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var th = new Thread(() => Application.Run(new Inicio()));
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();

            }
            */
        }

        private void BTNiniciar_Click(object sender, EventArgs e)
        {
            /* ---------------------------------------------------------------------------------------------------------BORRAR
            //abro la conexion
            conexion.Open();
            //establezco la cadena con la consulta de sql que quiero ejecutar
            string consulta = "select * from USUARIO where usuario='"+TXTname.Text+"' and contraseña='"+TXTcontraseña.Text+"'";
            //establezco variable de comandos
            SqlCommand comando = new SqlCommand(consulta,conexion);
            //para poder leer el codigo de ese lugar de sql, hay que establecer una variable de lectura
            SqlDataReader lector;
            lector = comando.ExecuteReader(); // con esto lee

            //verificamos si existe coincidencia en la base de datos con lo ingresado
            if (lector.HasRows == true)
            {
                MessageBox.Show("Bienvenido");
                var th = new Thread(() => Application.Run(new SesionIniciada()));
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();

            }
            else
            {
                MessageBox.Show("No se encontró coincidencia");
            }

            //cerramos la conexion
            conexion.Close();*/

            ///////////////////////marisa
            ///
            try
            {
                if (TXTcontraseña.Text != null && TXTname.Text != null)
                {
                    BE_USUARIO usuario = new BE_USUARIO(TXTname.Text, TXTcontraseña.Text);

                    if (blluser.Validar(usuario))
                    {
                        usuario = blluser.Recuperarusuario(usuario.Myuser);
                        if (SESION.Login(usuario))
                        {
                            MessageBox.Show("Bienvenido");
                            var th = new Thread(() => Application.Run(new Inicio()));
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                            this.Close();
                        } 
                        else
                        {
                            MessageBox.Show("Sesion ya iniciada.");
                            var th = new Thread(() => Application.Run(new Inicio()));
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                            this.Close();
                        }
                    } else
                    {
                        MessageBox.Show("Problema al iniciar sesión.");
                    }
                } else
                {
                    MessageBox.Show("Ingrese los datos");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                Limpiar();
            }

        }
        void Limpiar()
        {
            TXTcontraseña.Text = null;
            TXTname.Text = null;
        }

    }
}
