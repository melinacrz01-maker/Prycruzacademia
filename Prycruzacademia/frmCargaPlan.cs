using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Prycruzacademia
{
    public partial class frmCargaPlan : Form
    {
        string[] arrayPlanB = new string[10];
        int indice = 0;
        public frmCargaPlan()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtPlanb.Text == "")
            {
                arrayPlanB[indice] = txtPlanb.Text;
                MessageBox.Show("Ingrese el plan", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPlanb.Focus();
                return;
            }
            else
            {
                arrayPlanB[indice] = txtPlanb.Text;
                indice++;
                MessageBox.Show("Plan registrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPlanb.Clear();
                txtPlanb.Focus();
                if (indice == 10)
                {
                    btnRegistrar.Enabled = false;
                }
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lsPlanes.Items.Clear();
            for (int count = 0; count < indice; count++)
            {
                lsPlanes.Items.Add(arrayPlanB[count]);
            }
            
        }

        private void frmCargaPlan_Load(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtPlanb.Clear();
            lsPlanes.Items.Clear();
        }

        private void lsPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.ShowDialog();
        }
    }
}   

