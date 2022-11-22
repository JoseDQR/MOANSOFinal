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

        private void btnCalzado_Click(object sender, EventArgs e)
        {
            Form Calzado = new frmMantCalzado();
            Calzado.Show();
        }

        private void btnLineaCal_Click(object sender, EventArgs e)
        {
            Form LineaCal = new frmMantLineaCalzado();
            LineaCal.Show();
        }

        private void btnCatCal_Click(object sender, EventArgs e)
        {
            Form CatCal = new frmMantenedorCategoriaCalzado();
            CatCal.Show();
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            Form Materiales = new frmMantMateriales();
            Materiales.Show();
        }

        private void btnCatMat_Click(object sender, EventArgs e)
        {
            Form CatMat = new frmMantCategoriaMateriales();
            CatMat.Show();
        }
    }
}
