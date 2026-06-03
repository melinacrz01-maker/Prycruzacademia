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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos frmAlumnos = new frmAlumnos();
            frmAlumnos.ShowDialog();


        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos frmDatos = new frmDatos();
            frmDatos.ShowDialog();
        }

        private void planToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaPlan frmCargaPlan = new frmCargaPlan();
            frmCargaPlan.ShowDialog();
        }

        private void listadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListado frmListado = new frmListado();
            frmListado.ShowDialog();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
