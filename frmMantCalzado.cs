using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Logica;
using static System.Windows.Forms.LinkLabel;

namespace PrototipoMOANSOT2
{
    public partial class frmMantCalzado : Form
    {
        public frmMantCalzado()
        {
            InitializeComponent();
            ListarCalzado();
            llenarDatosComboBoxLineaCalzado();
            llenarDatosComboBoxCategoriaCalzado();
            groupBoxDatos.Enabled = false;
        }

        private void llenarDatosComboBoxLineaCalzado()
        {
            cbLinea.DataSource = Log_LineaCalzado.Instancia.ListarLineaCalzado();
            cbLinea.DisplayMember = "nombre";
            cbLinea.ValueMember = "linea_id";
        }

        private void llenarDatosComboBoxCategoriaCalzado()
        {
            cbCategoria.DataSource = Log_CategoriaCalzado.Instancia.ListarCategoriaCalzado();
            cbCategoria.DisplayMember = "nombre";
            cbCategoria.ValueMember = "categoria_id";
        }

        public void ListarCalzado()
        {
            dgvCalzado.DataSource = Log_Calzado.Instancia.ListarCalzado();
        }

        private void LimpiarVariables()
        {

            txtCalzado.Text = " ";
            txtStock.Text = " ";
            //txtDescripcion.Text = " ";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            groupBoxDatos.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Visible = true;
            btnModificar.Visible = false;
            btnRetirar.Visible = false;
            txtCalzado.Enabled = false;
            txtStock.Enabled = false;
            dgvCalzado.DataSource = Log_Calzado.Instancia.ListarCalzado();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = true;

            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Visible = false;
            btnRetirar.Visible = true;
            btnModificar.Visible = false;
            txtStock.Enabled = false;
            cbLinea.Enabled = false;
            cbCategoria.Enabled = false;
            LimpiarVariables();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            groupBoxDatos.Enabled = true;
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
            btnRetirar.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Ent_Calzado cal = new Ent_Calzado();
                cal.linea_id = Convert.ToInt32(cbLinea.SelectedValue);
                cal.categoria_id = Convert.ToInt32(cbCategoria.SelectedValue);
                Log_Calzado.Instancia.InsertarCalzado(cal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatos.Enabled = false;
            ListarCalzado();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            try
            {
                Ent_Calzado cal = new Ent_Calzado();
                cal.calzado_id = int.Parse(txtCalzado.Text.Trim());
                Log_Calzado.Instancia.EliminaCalzado(cal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatos.Enabled = false;
            ListarCalzado();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Ent_Calzado cal = new Ent_Calzado();
                cal.calzado_id = int.Parse(txtCalzado.Text.Trim());
                cal.linea_id = Convert.ToInt32(cbLinea.SelectedValue);
                cal.categoria_id = Convert.ToInt32(cbCategoria.SelectedValue);
                cal.stock = int.Parse(txtStock.Text.Trim());
                Log_Calzado.Instancia.EditarCalzado(cal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatos.Enabled = false;
            ListarCalzado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBoxDatos.Enabled = false;
        }

        private void dgvCalzado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCalzado.Rows[e.RowIndex]; //
            txtCalzado.Text = filaActual.Cells[0].Value.ToString();
            cbLinea.Text = filaActual.Cells[1].Value.ToString();
            cbCategoria.Text = filaActual.Cells[2].Value.ToString();
            txtStock.Text = filaActual.Cells[3].Value.ToString();
        }
    }
}
