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
    public partial class frmMantProveedor : Form
    {
        public frmMantProveedor()
        {
            InitializeComponent();
        }

        private void btnNuevoCli_Click(object sender, EventArgs e)
        {
            Form formularioNuevoProv = new NuevoProveedor();
            formularioNuevoProv.Show();
        }
    }
}
