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
          
        { e.Handled = true; }
            
        private void btnListado_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                MessageBox.Show("complete el codigo , campo obligatorio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtCodigo.Focus();
            return;
        }
        private void frmDatos_Load(object sender, EventArgs e)
        {
            cmbPlan.Items.Clear();
            cmbPlan.Items.Add("Plan A");
            cmbPlan.Items.Add("Plan B");
            cmbPlan.Items.Add("Plan C");
            cmbPlan.SelectedIndex = 0;


        }
    }
}
