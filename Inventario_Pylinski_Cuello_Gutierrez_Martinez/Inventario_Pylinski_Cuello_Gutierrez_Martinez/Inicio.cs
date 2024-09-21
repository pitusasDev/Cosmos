using SERVICIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_Pylinski_Cuello_Gutierrez_Martinez
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            if (SESION.ObtenerInstancia != null)
            {
                AdministrarCuenta frm = new AdministrarCuenta();
                frm.MdiParent = this;
                frm.MinimizeBox = true;
                frm.Show();
            }
        }


        private void MIsesion_Click(object sender, EventArgs e)
        {
            var th = new Thread(() => Application.Run(new InicioSesion()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void MIcerrarSesion_Click(object sender, EventArgs e)
        {
            SESION.Logout();
            MessageBox.Show("Chau!");

            var th = new Thread(() => Application.Run(new InicioSesion()));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
    }
}
