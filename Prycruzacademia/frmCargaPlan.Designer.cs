namespace Prycruzacademia
{
    partial class frmCargaPlan
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
            this.btnListar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblNombrePlan = new System.Windows.Forms.Label();
            this.txtPlanb = new System.Windows.Forms.TextBox();
            this.lsPlanes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnListar.Location = new System.Drawing.Point(135, 100);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegistrar.Location = new System.Drawing.Point(216, 100);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblNombrePlan
            // 
            this.lblNombrePlan.AutoSize = true;
            this.lblNombrePlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePlan.Location = new System.Drawing.Point(12, 49);
            this.lblNombrePlan.Name = "lblNombrePlan";
            this.lblNombrePlan.Size = new System.Drawing.Size(123, 16);
            this.lblNombrePlan.TabIndex = 2;
            this.lblNombrePlan.Text = "Nombre de Plan:";
            // 
            // txtPlanb
            // 
            this.txtPlanb.Location = new System.Drawing.Point(135, 49);
            this.txtPlanb.Name = "txtPlanb";
            this.txtPlanb.Size = new System.Drawing.Size(156, 20);
            this.txtPlanb.TabIndex = 3;
            // 
            // lsPlanes
            // 
            this.lsPlanes.FormattingEnabled = true;
            this.lsPlanes.Location = new System.Drawing.Point(89, 157);
            this.lsPlanes.Name = "lsPlanes";
            this.lsPlanes.Size = new System.Drawing.Size(142, 82);
            this.lsPlanes.TabIndex = 4;
            // 
            // frmCargaPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 274);
            this.Controls.Add(this.lsPlanes);
            this.Controls.Add(this.txtPlanb);
            this.Controls.Add(this.lblNombrePlan);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnListar);
            this.Name = "frmCargaPlan";
            this.Text = "frmCargaPlan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblNombrePlan;
        private System.Windows.Forms.TextBox txtPlanb;
        private System.Windows.Forms.ListBox lsPlanes;
    }
}