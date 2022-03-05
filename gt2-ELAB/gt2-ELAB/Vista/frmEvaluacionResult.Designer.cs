namespace gt2_ELAB.Vista
{
    partial class frmEvaluacionResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvaluacionResult));
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDestreza = new System.Windows.Forms.ComboBox();
            this.cbxEsfuerzo = new System.Windows.Forms.ComboBox();
            this.cbxCondiciones = new System.Windows.Forms.ComboBox();
            this.cbxConcistencia = new System.Windows.Forms.ComboBox();
            this.cbxToleranciaS = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificacion de Datos";
            // 
            // cbxDestreza
            // 
            this.cbxDestreza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDestreza.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDestreza.FormattingEnabled = true;
            this.cbxDestreza.Items.AddRange(new object[] {
            "0.15",
            "0.13",
            "0.11",
            "0.08",
            "0.06",
            "0.03",
            "0",
            "-0.05",
            "-0.1",
            "-0.16",
            "-0.22"});
            this.cbxDestreza.Location = new System.Drawing.Point(26, 104);
            this.cbxDestreza.Name = "cbxDestreza";
            this.cbxDestreza.Size = new System.Drawing.Size(85, 26);
            this.cbxDestreza.TabIndex = 1;
            // 
            // cbxEsfuerzo
            // 
            this.cbxEsfuerzo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEsfuerzo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEsfuerzo.FormattingEnabled = true;
            this.cbxEsfuerzo.Items.AddRange(new object[] {
            "0.13",
            "0.12",
            "0.1",
            "0.08",
            "0.05",
            "0.02",
            "0",
            "-0.04",
            "-0.18",
            "-0.12",
            "-0.17"});
            this.cbxEsfuerzo.Location = new System.Drawing.Point(139, 104);
            this.cbxEsfuerzo.Name = "cbxEsfuerzo";
            this.cbxEsfuerzo.Size = new System.Drawing.Size(85, 26);
            this.cbxEsfuerzo.TabIndex = 2;
            // 
            // cbxCondiciones
            // 
            this.cbxCondiciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCondiciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCondiciones.FormattingEnabled = true;
            this.cbxCondiciones.Items.AddRange(new object[] {
            "0.06",
            "0.04",
            "0.02",
            "0",
            "-0.03",
            "-0.07"});
            this.cbxCondiciones.Location = new System.Drawing.Point(257, 104);
            this.cbxCondiciones.Name = "cbxCondiciones";
            this.cbxCondiciones.Size = new System.Drawing.Size(85, 26);
            this.cbxCondiciones.TabIndex = 3;
            // 
            // cbxConcistencia
            // 
            this.cbxConcistencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConcistencia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxConcistencia.FormattingEnabled = true;
            this.cbxConcistencia.Items.AddRange(new object[] {
            "0.04",
            "0.03",
            "0.01",
            "0",
            "-0.02",
            "-0.04"});
            this.cbxConcistencia.Location = new System.Drawing.Point(370, 104);
            this.cbxConcistencia.Name = "cbxConcistencia";
            this.cbxConcistencia.Size = new System.Drawing.Size(85, 26);
            this.cbxConcistencia.TabIndex = 4;
            // 
            // cbxToleranciaS
            // 
            this.cbxToleranciaS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxToleranciaS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxToleranciaS.FormattingEnabled = true;
            this.cbxToleranciaS.Items.AddRange(new object[] {
            "0.01",
            "0.02",
            "0.03",
            "0.04",
            "0.05",
            "0.06",
            "0.07",
            "0.08",
            "0.09",
            "0.10",
            "0.11",
            "0.12",
            "0.13",
            "0.14",
            "0.15",
            "0.16",
            "0.17",
            "0.18",
            "0.19",
            "0.20",
            "0.21",
            "0.22",
            "0.23",
            "0.24",
            "0.25",
            "0.26",
            "0.27",
            "0.28",
            "0.29",
            "0.30",
            "0.31",
            "0.32",
            "0.33",
            "0.34",
            "0.35",
            "0.36",
            "0.37",
            "0.38",
            "0.39",
            "0.40",
            "0.41",
            "0.42",
            "0.43",
            "0.44",
            "0.45",
            "0.46",
            "0.47",
            "0.48",
            "0.49",
            "0.50",
            "0.51",
            "0.52",
            "0.53",
            "0.54",
            "0.55",
            "0.56",
            "0.57",
            "0.58",
            "0.59",
            "0.60",
            "0.61",
            "0.62",
            "0.63",
            "0.64",
            "0.65",
            "0.66",
            "0.67",
            "0.68",
            "0.69",
            "0.70",
            "0.71",
            "0.72",
            "0.73",
            "0.74",
            "0.75",
            "0.76",
            "0.77",
            "0.78",
            "0.79",
            "0.80",
            "0.81",
            "0.82",
            "0.83",
            "0.84",
            "0.85",
            "0.86",
            "0.87",
            "0.88",
            "0.89",
            "0.90",
            "0.91",
            "0.92",
            "0.93",
            "0.94",
            "0.95",
            "0.96",
            "0.97",
            "0.98",
            "0.99"});
            this.cbxToleranciaS.Location = new System.Drawing.Point(668, 104);
            this.cbxToleranciaS.Name = "cbxToleranciaS";
            this.cbxToleranciaS.Size = new System.Drawing.Size(85, 26);
            this.cbxToleranciaS.TabIndex = 5;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(502, 104);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Destreza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Esfuerzo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Condiciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(367, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Concistencia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(529, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(631, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tolerancia Suplemento";
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.White;
            this.btnTotal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(24)))), ((int)(((byte)(48)))));
            this.btnTotal.FlatAppearance.BorderSize = 3;
            this.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.ForeColor = System.Drawing.Color.Black;
            this.btnTotal.Location = new System.Drawing.Point(502, 136);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(100, 50);
            this.btnTotal.TabIndex = 13;
            this.btnTotal.Text = "Icono";
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 37);
            this.panel1.TabIndex = 14;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(764, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 37);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(257, 215);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(122, 54);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(24)))), ((int)(((byte)(48)))));
            this.btnCancelar.FlatAppearance.BorderSize = 3;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(422, 215);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 54);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmEvaluacionResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 281);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.cbxToleranciaS);
            this.Controls.Add(this.cbxConcistencia);
            this.Controls.Add(this.cbxCondiciones);
            this.Controls.Add(this.cbxEsfuerzo);
            this.Controls.Add(this.cbxDestreza);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEvaluacionResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEvaluacionResult";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDestreza;
        private System.Windows.Forms.ComboBox cbxEsfuerzo;
        private System.Windows.Forms.ComboBox cbxCondiciones;
        private System.Windows.Forms.ComboBox cbxConcistencia;
        private System.Windows.Forms.ComboBox cbxToleranciaS;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCerrar;
    }
}