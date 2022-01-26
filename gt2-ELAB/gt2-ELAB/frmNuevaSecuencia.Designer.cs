namespace gt2_ELAB
{
    partial class frmNuevaSecuencia
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
            this.boxSecuencia = new System.Windows.Forms.TextBox();
            this.boxCiclos = new System.Windows.Forms.TextBox();
            this.boxEstaciones = new System.Windows.Forms.TextBox();
            this.btnSig = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCiclos = new System.Windows.Forms.Label();
            this.labelEstaciones = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxSecuencia
            // 
            this.boxSecuencia.Location = new System.Drawing.Point(41, 71);
            this.boxSecuencia.Name = "boxSecuencia";
            this.boxSecuencia.Size = new System.Drawing.Size(283, 20);
            this.boxSecuencia.TabIndex = 0;
            // 
            // boxCiclos
            // 
            this.boxCiclos.Location = new System.Drawing.Point(41, 161);
            this.boxCiclos.Name = "boxCiclos";
            this.boxCiclos.Size = new System.Drawing.Size(94, 20);
            this.boxCiclos.TabIndex = 1;
            // 
            // boxEstaciones
            // 
            this.boxEstaciones.Location = new System.Drawing.Point(201, 161);
            this.boxEstaciones.Name = "boxEstaciones";
            this.boxEstaciones.Size = new System.Drawing.Size(94, 20);
            this.boxEstaciones.TabIndex = 2;
            // 
            // btnSig
            // 
            this.btnSig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(24)))), ((int)(((byte)(48)))));
            this.btnSig.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSig.ForeColor = System.Drawing.Color.White;
            this.btnSig.Location = new System.Drawing.Point(183, 206);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(94, 34);
            this.btnSig.TabIndex = 3;
            this.btnSig.Text = "Siguiente";
            this.btnSig.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(24)))), ((int)(((byte)(48)))));
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(303, 206);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 34);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(38, 55);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(116, 13);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "Nombre de Secuencia:";
            // 
            // labelCiclos
            // 
            this.labelCiclos.AutoSize = true;
            this.labelCiclos.Location = new System.Drawing.Point(38, 145);
            this.labelCiclos.Name = "labelCiclos";
            this.labelCiclos.Size = new System.Drawing.Size(55, 13);
            this.labelCiclos.TabIndex = 6;
            this.labelCiclos.Text = "No. Ciclos";
            // 
            // labelEstaciones
            // 
            this.labelEstaciones.AutoSize = true;
            this.labelEstaciones.Location = new System.Drawing.Point(198, 145);
            this.labelEstaciones.Name = "labelEstaciones";
            this.labelEstaciones.Size = new System.Drawing.Size(79, 13);
            this.labelEstaciones.TabIndex = 7;
            this.labelEstaciones.Text = "No. Estaciones";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 30);
            this.panel1.TabIndex = 8;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(350, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(57, 30);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // frmNuevaSecuencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 252);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelEstaciones);
            this.Controls.Add(this.labelCiclos);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.boxEstaciones);
            this.Controls.Add(this.boxCiclos);
            this.Controls.Add(this.boxSecuencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevaSecuencia";
            this.Text = "frmNuevaSecuencia";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxSecuencia;
        private System.Windows.Forms.TextBox boxCiclos;
        private System.Windows.Forms.TextBox boxEstaciones;
        private System.Windows.Forms.Button btnSig;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCiclos;
        private System.Windows.Forms.Label labelEstaciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
    }
}