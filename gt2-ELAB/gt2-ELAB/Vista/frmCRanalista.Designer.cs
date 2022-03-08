namespace gt2_ELAB.Vista
{
    partial class frmCRanalista
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
            this.crystalViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalViewer
            // 
            this.crystalViewer.ActiveViewIndex = -1;
            this.crystalViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalViewer.Location = new System.Drawing.Point(0, 0);
            this.crystalViewer.Name = "crystalViewer";
            this.crystalViewer.Size = new System.Drawing.Size(800, 480);
            this.crystalViewer.TabIndex = 0;
            this.crystalViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmCRanalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.crystalViewer);
            this.Name = "frmCRanalista";
            this.Text = "Reporte Análista";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalViewer;
    }
}