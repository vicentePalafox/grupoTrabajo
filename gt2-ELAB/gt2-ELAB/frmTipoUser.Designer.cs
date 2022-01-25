namespace gt2_ELAB
{
    partial class frmTipoUser
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
            this.bntMaestro = new System.Windows.Forms.Button();
            this.btnAlumno = new System.Windows.Forms.Button();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.PanelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntMaestro
            // 
            this.bntMaestro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(24)))), ((int)(((byte)(48)))));
            this.bntMaestro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntMaestro.ForeColor = System.Drawing.Color.White;
            this.bntMaestro.Location = new System.Drawing.Point(157, 80);
            this.bntMaestro.Name = "bntMaestro";
            this.bntMaestro.Size = new System.Drawing.Size(106, 36);
            this.bntMaestro.TabIndex = 0;
            this.bntMaestro.Text = "Maestro";
            this.bntMaestro.UseVisualStyleBackColor = false;
            // 
            // btnAlumno
            // 
            this.btnAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(24)))), ((int)(((byte)(48)))));
            this.btnAlumno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumno.ForeColor = System.Drawing.Color.White;
            this.btnAlumno.Location = new System.Drawing.Point(157, 168);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(106, 36);
            this.btnAlumno.TabIndex = 1;
            this.btnAlumno.Text = "Alumno";
            this.btnAlumno.UseVisualStyleBackColor = false;
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.PanelTitulo.Controls.Add(this.btnCerrar);
            this.PanelTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelTitulo.Location = new System.Drawing.Point(-1, -1);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(429, 39);
            this.PanelTitulo.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(382, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(47, 39);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // frmTipoUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 247);
            this.Controls.Add(this.PanelTitulo);
            this.Controls.Add(this.btnAlumno);
            this.Controls.Add(this.bntMaestro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTipoUser";
            this.Text = "frmTipoUser";
            this.PanelTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntMaestro;
        private System.Windows.Forms.Button btnAlumno;
        private System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.Button btnCerrar;
    }
}