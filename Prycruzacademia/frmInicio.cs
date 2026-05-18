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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDatos ventana = new frmDatos();
            ventana.ShowDialog();
            this.Hide();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            DateTime varIncioSesion = DateTime.Now;

        }
    }
}
