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
    public partial class frmListado : Form
    {
        public string[,] arrMateriasListado = new string[4, 5];
        public frmListado()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvGrilla.Rows.Clear();
            if (rbtBuscar.Checked == true)
            {
                for (int count = 0; count < arrMateriasListado.GetLength(1); count++)
                {
                    
                    dgvGrilla.Rows.Add(arrMateriasListado[count, 0], arrMateriasListado[count, 1], arrMateriasListado[count, 2], arrMateriasListado[count, 3]);
                    
                }
            }
        }




        private void dgvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rdbtodo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
