﻿namespace gt2_ELAB
{
    partial class frmEjecucion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEjecucion));
            this.lblAviso = new System.Windows.Forms.Label();
            this.pictureTarea = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.btnInicia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tmrRegresivo = new System.Windows.Forms.Timer(this.components);
            this.tmrProceso = new System.Windows.Forms.Timer(this.components);
            this.tmrBuscaGrupo = new System.Windows.Forms.Timer(this.components);
            this.lblAvisoBusqueda = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblseg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTseg = new System.Windows.Forms.Label();
            this.lblTmilis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEstacion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPzCola = new System.Windows.Forms.Label();
            this.tmrPzCola = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCicloAct = new System.Windows.Forms.Label();
            this.lblCicloTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTarea)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAviso
            // 
            this.lblAviso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.Location = new System.Drawing.Point(32, 106);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(153, 44);
            this.lblAviso.TabIndex = 0;
            this.lblAviso.Text = "Preparados";
            // 
            // pictureTarea
            // 
            this.pictureTarea.Location = new System.Drawing.Point(218, 140);
            this.pictureTarea.Name = "pictureTarea";
            this.pictureTarea.Size = new System.Drawing.Size(413, 228);
            this.pictureTarea.TabIndex = 1;
            this.pictureTarea.TabStop = false;
            this.pictureTarea.Click += new System.EventHandler(this.pictureTarea_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Para tomar el tiempo, Haz click sobre la imagen.";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(215, 380);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(468, 87);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción de la tarea.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 43);
            this.panel1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(48, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 27);
            this.label9.TabIndex = 24;
            this.label9.Text = "Ejecución";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCerrar.Location = new System.Drawing.Point(779, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(48, 43);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(73, 154);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(22, 24);
            this.lblContador.TabIndex = 5;
            this.lblContador.Text = "0";
            // 
            // btnInicia
            // 
            this.btnInicia.Enabled = false;
            this.btnInicia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicia.Location = new System.Drawing.Point(52, 221);
            this.btnInicia.Name = "btnInicia";
            this.btnInicia.Size = new System.Drawing.Size(112, 40);
            this.btnInicia.TabIndex = 6;
            this.btnInicia.Text = "Comenzar";
            this.btnInicia.UseVisualStyleBackColor = true;
            this.btnInicia.Click += new System.EventHandler(this.btnInicia_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tiempo Transcurrido";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // tmrRegresivo
            // 
            this.tmrRegresivo.Interval = 1000;
            this.tmrRegresivo.Tick += new System.EventHandler(this.tmrRegresivo_Tick);
            // 
            // tmrProceso
            // 
            this.tmrProceso.Interval = 10;
            this.tmrProceso.Tick += new System.EventHandler(this.tmrProceso_Tick);
            // 
            // tmrBuscaGrupo
            // 
            this.tmrBuscaGrupo.Tick += new System.EventHandler(this.tmrBuscaGrupo_Tick);
            // 
            // lblAvisoBusqueda
            // 
            this.lblAvisoBusqueda.AutoSize = true;
            this.lblAvisoBusqueda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvisoBusqueda.Location = new System.Drawing.Point(55, 50);
            this.lblAvisoBusqueda.Name = "lblAvisoBusqueda";
            this.lblAvisoBusqueda.Size = new System.Drawing.Size(254, 18);
            this.lblAvisoBusqueda.TabIndex = 9;
            this.lblAvisoBusqueda.Text = "Buscando a los otros dos analistas:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(317, 50);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(20, 18);
            this.lblMin.TabIndex = 10;
            this.lblMin.Text = "**";
            // 
            // lblseg
            // 
            this.lblseg.AutoSize = true;
            this.lblseg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseg.Location = new System.Drawing.Point(354, 50);
            this.lblseg.Name = "lblseg";
            this.lblseg.Size = new System.Drawing.Size(20, 18);
            this.lblseg.TabIndex = 11;
            this.lblseg.Text = "**";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(341, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = ":";
            // 
            // lblTseg
            // 
            this.lblTseg.AutoSize = true;
            this.lblTseg.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTseg.Location = new System.Drawing.Point(61, 335);
            this.lblTseg.Name = "lblTseg";
            this.lblTseg.Size = new System.Drawing.Size(30, 27);
            this.lblTseg.TabIndex = 13;
            this.lblTseg.Text = "**";
            // 
            // lblTmilis
            // 
            this.lblTmilis.AutoSize = true;
            this.lblTmilis.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTmilis.Location = new System.Drawing.Point(111, 335);
            this.lblTmilis.Name = "lblTmilis";
            this.lblTmilis.Size = new System.Drawing.Size(30, 27);
            this.lblTmilis.TabIndex = 14;
            this.lblTmilis.Text = "**";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(682, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "No. Estación";
            // 
            // lblEstacion
            // 
            this.lblEstacion.AutoSize = true;
            this.lblEstacion.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstacion.Location = new System.Drawing.Point(709, 140);
            this.lblEstacion.Name = "lblEstacion";
            this.lblEstacion.Size = new System.Drawing.Size(22, 24);
            this.lblEstacion.TabIndex = 17;
            this.lblEstacion.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(669, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Piezas en cola";
            // 
            // lblPzCola
            // 
            this.lblPzCola.AutoSize = true;
            this.lblPzCola.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPzCola.Location = new System.Drawing.Point(713, 235);
            this.lblPzCola.Name = "lblPzCola";
            this.lblPzCola.Size = new System.Drawing.Size(22, 24);
            this.lblPzCola.TabIndex = 19;
            this.lblPzCola.Text = "0";
            // 
            // tmrPzCola
            // 
            this.tmrPzCola.Interval = 500;
            this.tmrPzCola.Tick += new System.EventHandler(this.tmrPzCola_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(704, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ciclo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(714, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "/";
            // 
            // lblCicloAct
            // 
            this.lblCicloAct.AutoSize = true;
            this.lblCicloAct.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCicloAct.Location = new System.Drawing.Point(693, 329);
            this.lblCicloAct.Name = "lblCicloAct";
            this.lblCicloAct.Size = new System.Drawing.Size(22, 24);
            this.lblCicloAct.TabIndex = 22;
            this.lblCicloAct.Text = "0";
            // 
            // lblCicloTotal
            // 
            this.lblCicloTotal.AutoSize = true;
            this.lblCicloTotal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCicloTotal.Location = new System.Drawing.Point(732, 329);
            this.lblCicloTotal.Name = "lblCicloTotal";
            this.lblCicloTotal.Size = new System.Drawing.Size(22, 24);
            this.lblCicloTotal.TabIndex = 23;
            this.lblCicloTotal.Text = "0";
            // 
            // frmEjecucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 476);
            this.Controls.Add(this.lblCicloTotal);
            this.Controls.Add(this.lblCicloAct);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPzCola);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblEstacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTmilis);
            this.Controls.Add(this.lblTseg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblseg);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblAvisoBusqueda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnInicia);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureTarea);
            this.Controls.Add(this.lblAviso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEjecucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEjecucion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEjecucion_FormClosing);
            this.Load += new System.EventHandler(this.frmEjecucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTarea)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.PictureBox pictureTarea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnInicia;
        private System.Windows.Forms.Label label4;
        internal System.ComponentModel.BackgroundWorker backgroundWorker1;
        internal System.Windows.Forms.Timer tmrRegresivo;
        internal System.Windows.Forms.Timer tmrProceso;
        internal System.Windows.Forms.Timer tmrBuscaGrupo;
        private System.Windows.Forms.Label lblAvisoBusqueda;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblseg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTseg;
        private System.Windows.Forms.Label lblTmilis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEstacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPzCola;
        private System.Windows.Forms.Timer tmrPzCola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCicloAct;
        private System.Windows.Forms.Label lblCicloTotal;
        private System.Windows.Forms.Label label9;
    }
}