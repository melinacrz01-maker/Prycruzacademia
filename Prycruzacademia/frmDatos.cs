using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prycruzacademia
{
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void btnListado_Click(object sender, EventArgs e)
        {
            frmListado ventana = new frmListado();
            ventana.ShowDialog();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese el codigo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }
            if (cmbPlan.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un plan", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPlan.Focus();
                return;
            }
            if (Chbarchivo.Checked == false)
            {
                MessageBox.Show("Seleccione el tipo de archivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Chbarchivo.Focus();
                return;
            }
        }

        private void frmDatos_Load(object sender, EventArgs e)
        {
            cmbPlan.Items.Clear();
            cmbPlan.Items.Add("Plan 1");
            cmbPlan.Items.Add("Plan 2");
            cmbPlan.Items.Add("Plan 3");
            cmbPlan.SelectedIndex = 0;


        }

        private void btnPlancarga_Click(object sender, EventArgs e)
        {
            frmCargaPlan ventana = new frmCargaPlan();
            ventana.ShowDialog();
            this.Hide();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            cmbPlan.SelectedIndex = -1;
            Chbarchivo.Checked = false;

            lblActivo.Text = "Activo";

        }
    }
}
