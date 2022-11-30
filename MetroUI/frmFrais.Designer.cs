namespace MetroUI
{
    partial class frmFrais
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumFrais = new System.Windows.Forms.TextBox();
            this.fraiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNomFrais = new System.Windows.Forms.TextBox();
            this.gpbFrais = new System.Windows.Forms.GroupBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.metroGridFrais = new MetroFramework.Controls.MetroGrid();
            this.numFraisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomFraisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEnreg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fraiBindingSource)).BeginInit();
            this.gpbFrais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridFrais)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro frais :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom frais :";
            // 
            // txtNumFrais
            // 
            this.txtNumFrais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fraiBindingSource, "NumFrais", true));
            this.txtNumFrais.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumFrais.Location = new System.Drawing.Point(107, 26);
            this.txtNumFrais.Name = "txtNumFrais";
            this.txtNumFrais.Size = new System.Drawing.Size(111, 21);
            this.txtNumFrais.TabIndex = 0;
            // 
            // fraiBindingSource
            // 
            this.fraiBindingSource.DataSource = typeof(MetroUI.Frai);
            // 
            // txtNomFrais
            // 
            this.txtNomFrais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fraiBindingSource, "NomFrais", true));
            this.txtNomFrais.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomFrais.Location = new System.Drawing.Point(107, 59);
            this.txtNomFrais.Name = "txtNomFrais";
            this.txtNomFrais.Size = new System.Drawing.Size(206, 21);
            this.txtNomFrais.TabIndex = 1;
            // 
            // gpbFrais
            // 
            this.gpbFrais.Controls.Add(this.txtNumFrais);
            this.gpbFrais.Controls.Add(this.txtNomFrais);
            this.gpbFrais.Controls.Add(this.label1);
            this.gpbFrais.Controls.Add(this.label2);
            this.gpbFrais.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFrais.Location = new System.Drawing.Point(16, 57);
            this.gpbFrais.Name = "gpbFrais";
            this.gpbFrais.Size = new System.Drawing.Size(326, 102);
            this.gpbFrais.TabIndex = 3;
            this.gpbFrais.TabStop = false;
            this.gpbFrais.Text = "Frais à payer";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Aqua;
            this.btnAjouter.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAjouter.Location = new System.Drawing.Point(23, 165);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(66, 40);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Aqua;
            this.btnModifier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnModifier.Location = new System.Drawing.Point(171, 165);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(77, 40);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Aqua;
            this.btnSupprimer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSupprimer.Location = new System.Drawing.Point(254, 165);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(88, 40);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            // 
            // metroGridFrais
            // 
            this.metroGridFrais.AllowUserToAddRows = false;
            this.metroGridFrais.AllowUserToResizeRows = false;
            this.metroGridFrais.AutoGenerateColumns = false;
            this.metroGridFrais.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridFrais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGridFrais.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridFrais.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridFrais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridFrais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridFrais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numFraisDataGridViewTextBoxColumn,
            this.nomFraisDataGridViewTextBoxColumn});
            this.metroGridFrais.DataSource = this.fraiBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridFrais.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridFrais.EnableHeadersVisualStyles = false;
            this.metroGridFrais.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridFrais.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridFrais.Location = new System.Drawing.Point(16, 219);
            this.metroGridFrais.Name = "metroGridFrais";
            this.metroGridFrais.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridFrais.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridFrais.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridFrais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridFrais.Size = new System.Drawing.Size(326, 215);
            this.metroGridFrais.TabIndex = 4;
            // 
            // numFraisDataGridViewTextBoxColumn
            // 
            this.numFraisDataGridViewTextBoxColumn.DataPropertyName = "NumFrais";
            this.numFraisDataGridViewTextBoxColumn.HeaderText = "FRAIS ID";
            this.numFraisDataGridViewTextBoxColumn.Name = "numFraisDataGridViewTextBoxColumn";
            // 
            // nomFraisDataGridViewTextBoxColumn
            // 
            this.nomFraisDataGridViewTextBoxColumn.DataPropertyName = "NomFrais";
            this.nomFraisDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
            this.nomFraisDataGridViewTextBoxColumn.Name = "nomFraisDataGridViewTextBoxColumn";
            this.nomFraisDataGridViewTextBoxColumn.Width = 180;
            // 
            // btnEnreg
            // 
            this.btnEnreg.BackColor = System.Drawing.Color.Aqua;
            this.btnEnreg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnreg.Location = new System.Drawing.Point(95, 165);
            this.btnEnreg.Name = "btnEnreg";
            this.btnEnreg.Size = new System.Drawing.Size(65, 39);
            this.btnEnreg.TabIndex = 5;
            this.btnEnreg.Text = "&Save";
            this.btnEnreg.UseVisualStyleBackColor = false;
            this.btnEnreg.Click += new System.EventHandler(this.btnEnreg_Click);
            // 
            // frmFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 457);
            this.Controls.Add(this.btnEnreg);
            this.Controls.Add(this.metroGridFrais);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.gpbFrais);
            this.MaximizeBox = false;
            this.Name = "frmFrais";
            this.ShowIcon = false;
            this.Text = "Tous les frais";
            this.Load += new System.EventHandler(this.frmFrais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fraiBindingSource)).EndInit();
            this.gpbFrais.ResumeLayout(false);
            this.gpbFrais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridFrais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumFrais;
        private System.Windows.Forms.TextBox txtNomFrais;
        private System.Windows.Forms.GroupBox gpbFrais;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private MetroFramework.Controls.MetroGrid metroGridFrais;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFraisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomFraisDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fraiBindingSource;
        private System.Windows.Forms.Button btnEnreg;
    }
}