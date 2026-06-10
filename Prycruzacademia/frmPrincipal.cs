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
        private string[,] arrMaterias = new string[5, 4];
        private string[] arrPlan= new string[5];

        public frmPrincipal()
        {
            InitializeComponent();
            arrPlan[1] = "Plan 1";
            arrPlan[2] = "Plan 2";
            arrPlan[3] = "Plan 3";
        }

        public frmPrincipal(string[] arrayPlanB)
        {
            InitializeComponent();
            arrPlan = arrayPlanB;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos frmAlumnos = new frmAlumnos();
            frmAlumnos.ShowDialog();


        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos frmDatos = new frmDatos(arrMaterias, arrPlan);
            frmDatos.ShowDialog();
        }

        private void planToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaPlan frmCargaPlan = new frmCargaPlan(arrPlan);
            frmCargaPlan.ShowDialog();
        }

        private void listadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListado frmListado = new frmListado(arrMaterias);
            frmListado.ShowDialog();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
