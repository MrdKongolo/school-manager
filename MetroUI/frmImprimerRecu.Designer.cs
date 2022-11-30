namespace MetroUI
{
    partial class frmImprimerRecu
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
            this.reportViewerRecu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerRecu
            // 
            this.reportViewerRecu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerRecu.LocalReport.ReportEmbeddedResource = "MetroUI.rptRecu.rdlc";
            this.reportViewerRecu.Location = new System.Drawing.Point(20, 60);
            this.reportViewerRecu.Name = "reportViewerRecu";
            this.reportViewerRecu.Size = new System.Drawing.Size(536, 503);
            this.reportViewerRecu.TabIndex = 0;
            // 
            // frmImprimerRecu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 583);
            this.Controls.Add(this.reportViewerRecu);
            this.MaximizeBox = false;
            this.Name = "frmImprimerRecu";
            this.Text = "Impression d\'un reçu";
            this.Load += new System.EventHandler(this.frmImprimerRecu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerRecu;
    }
}