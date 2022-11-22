using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoMOANSOT2
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Form formularioProducto = new frmMantProductos();
            formularioProducto.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form formularioClientes = new frmMantProveedor();
            formularioClientes.Show();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            Form formularioPersonal = new frmMantPersonal();
            formularioPersonal.Show();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            Form formularioPedido = new frmMantPedido();
            formularioPedido.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
