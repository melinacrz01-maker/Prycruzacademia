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

        string[] dni;
        string[] nombre;
        string[] apellido;
        string[] direccion;
        string[] contacto;
        string[] fecha;
        int indice = 0;
        public frmAlumnos(string[] arrDni, string[] arrNombre, string[] arrApellido, string[] arrDireccion, string[] arrContacto, string[] arrFecha)
            
        {
            InitializeComponent();
            dni = arrDni;
            nombre = arrNombre;
            apellido = arrApellido;
            direccion = arrDireccion;
            contacto = arrContacto;
            fecha = arrFecha;

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

        private void btnListardatos_Click(object sender, EventArgs e)
        {
            frmListado ventaListado = new frmListado();
            ventaListado.Show();

        }
    }
}
