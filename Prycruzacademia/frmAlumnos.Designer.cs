namespace Prycruzacademia
{
    partial class frmAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumnos));
            this.lblDni = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnListardatos = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.mskContacto = new System.Windows.Forms.MaskedTextBox();
            this.mskDni = new System.Windows.Forms.MaskedTextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(23, 46);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(31, 15);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(23, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(23, 126);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 15);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(227, 46);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(68, 15);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Direcciòn";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto.Location = new System.Drawing.Point(227, 85);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(63, 15);
            this.lblContacto.TabIndex = 4;
            this.lblContacto.Text = "Contacto";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(227, 126);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(143, 15);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha de Nacimiento";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(88, 85);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(73, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(88, 126);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(73, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(297, 45);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(85, 20);
            this.txtDireccion.TabIndex = 9;
            // 
            // btnListardatos
            // 
            this.btnListardatos.BackColor = System.Drawing.Color.LightGreen;
            this.btnListardatos.Location = new System.Drawing.Point(208, 172);
            this.btnListardatos.Name = "btnListardatos";
            this.btnListardatos.Size = new System.Drawing.Size(75, 23);
            this.btnListardatos.TabIndex = 11;
            this.btnListardatos.Text = "Listar";
            this.btnListardatos.UseVisualStyleBackColor = false;
            this.btnListardatos.Click += new System.EventHandler(this.btnListardatos_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEdit.Location = new System.Drawing.Point(300, 172);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.Location = new System.Drawing.Point(390, 172);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // mskContacto
            // 
            this.mskContacto.Location = new System.Drawing.Point(297, 85);
            this.mskContacto.Mask = "(999)000-0000";
            this.mskContacto.Name = "mskContacto";
            this.mskContacto.Size = new System.Drawing.Size(108, 20);
            this.mskContacto.TabIndex = 14;
            // 
            // mskDni
            // 
            this.mskDni.Location = new System.Drawing.Point(61, 45);
            this.mskDni.Mask = "99999";
            this.mskDni.Name = "mskDni";
            this.mskDni.Size = new System.Drawing.Size(100, 20);
            this.mskDni.TabIndex = 16;
            this.mskDni.ValidatingType = typeof(int);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(376, 126);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(115, 20);
            this.dtpFecha.TabIndex = 17;
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnvolver.Location = new System.Drawing.Point(12, 12);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(75, 23);
            this.btnvolver.TabIndex = 18;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(510, 207);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.mskDni);
            this.Controls.Add(this.mskContacto);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnListardatos);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Alumnos ";
            this.Load += new System.EventHandler(this.frmAlumnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnListardatos;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.MaskedTextBox mskContacto;
        private System.Windows.Forms.MaskedTextBox mskDni;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnvolver;
    }
}