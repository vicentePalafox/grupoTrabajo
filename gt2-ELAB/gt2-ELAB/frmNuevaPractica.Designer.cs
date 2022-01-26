namespace gt2_ELAB
{
    partial class frmNuevaPractica
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
            this.boxPractica = new System.Windows.Forms.TextBox();
            this.comboSeleccion = new System.Windows.Forms.ComboBox();
            this.boxCiclos = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPractica = new System.Windows.Forms.Label();
            this.labelSeleccion = new System.Windows.Forms.Label();
            this.labelCiclos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxPractica
            // 
            this.boxPractica.Location = new System.Drawing.Point(45, 93);
            this.boxPractica.Name = "boxPractica";
            this.boxPractica.Size = new System.Drawing.Size(152, 20);
            this.boxPractica.TabIndex = 0;
            // 
            // comboSeleccion
            // 
            this.comboSeleccion.FormattingEnabled = true;
            this.comboSeleccion.Location = new System.Drawing.Point(45, 159);
            this.comboSeleccion.Name = "comboSeleccion";
            this.comboSeleccion.Size = new System.Drawing.Size(152, 21);
            this.comboSeleccion.TabIndex = 1;
            // 
            // boxCiclos
            // 
            this.boxCiclos.Location = new System.Drawing.Point(45, 230);
            this.boxCiclos.Name = "boxCiclos";
            this.boxCiclos.Size = new System.Drawing.Size(100, 20);
            this.boxCiclos.TabIndex = 2;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(24)))), ((int)(((byte)(48)))));
            this.btnNuevo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(272, 132);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(124, 48);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Crear Nueva Secuencia";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.panel1.Location = new System.Drawing.Point(218, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 199);
            this.panel1.TabIndex = 4;
            // 
            // labelPractica
            // 
            this.labelPractica.AutoSize = true;
            this.labelPractica.Location = new System.Drawing.Point(42, 67);
            this.labelPractica.Name = "labelPractica";
            this.labelPractica.Size = new System.Drawing.Size(81, 13);
            this.labelPractica.TabIndex = 5;
            this.labelPractica.Text = "Nueva Practica";
            // 
            // labelSeleccion
            // 
            this.labelSeleccion.AutoSize = true;
            this.labelSeleccion.Location = new System.Drawing.Point(42, 132);
            this.labelSeleccion.Name = "labelSeleccion";
            this.labelSeleccion.Size = new System.Drawing.Size(148, 13);
            this.labelSeleccion.TabIndex = 6;
            this.labelSeleccion.Text = "Seleccione Secuencia a Usar";
            // 
            // labelCiclos
            // 
            this.labelCiclos.AutoSize = true;
            this.labelCiclos.Location = new System.Drawing.Point(42, 200);
            this.labelCiclos.Name = "labelCiclos";
            this.labelCiclos.Size = new System.Drawing.Size(55, 13);
            this.labelCiclos.TabIndex = 7;
            this.labelCiclos.Text = "No. Ciclos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Location = new System.Drawing.Point(-1, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 36);
            this.panel2.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(397, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmNuevaPractica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 301);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelCiclos);
            this.Controls.Add(this.labelSeleccion);
            this.Controls.Add(this.labelPractica);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.boxCiclos);
            this.Controls.Add(this.comboSeleccion);
            this.Controls.Add(this.boxPractica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevaPractica";
            this.Text = "frmNuevaPractica";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxPractica;
        private System.Windows.Forms.ComboBox comboSeleccion;
        private System.Windows.Forms.TextBox boxCiclos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPractica;
        private System.Windows.Forms.Label labelSeleccion;
        private System.Windows.Forms.Label labelCiclos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
    }
}