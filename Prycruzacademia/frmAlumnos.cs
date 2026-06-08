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
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            mskDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            mskContacto.Clear();
            dtpFecha.Value = DateTime.Today;

           

        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {

        }
    }
}
