namespace MetroUI
{
    partial class frmClasse
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroGridClasse = new MetroFramework.Controls.MetroGrid();
            this.codeClasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCodeClasse = new MetroFramework.Controls.MetroTextBox();
            this.txtClasse = new MetroFramework.Controls.MetroTextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridClasse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Code Classe : ";
            // 
            // metroGridClasse
            // 
            this.metroGridClasse.AllowUserToResizeRows = false;
            this.metroGridClasse.AutoGenerateColumns = false;
            this.metroGridClasse.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridClasse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGridClasse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridClasse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridClasse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridClasse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeClasseDataGridViewTextBoxColumn,
            this.classeDataGridViewTextBoxColumn});
            this.metroGridClasse.DataSource = this.classBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridClasse.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridClasse.EnableHeadersVisualStyles = false;
            this.metroGridClasse.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridClasse.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridClasse.Location = new System.Drawing.Point(360, 75);
            this.metroGridClasse.Name = "metroGridClasse";
            this.metroGridClasse.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridClasse.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridClasse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridClasse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridClasse.Size = new System.Drawing.Size(358, 255);
            this.metroGridClasse.TabIndex = 1;
            this.metroGridClasse.TabStop = false;
            // 
            // codeClasseDataGridViewTextBoxColumn
            // 
            this.codeClasseDataGridViewTextBoxColumn.DataPropertyName = "CodeClasse";
            this.codeClasseDataGridViewTextBoxColumn.HeaderText = "Code de la classe";
            this.codeClasseDataGridViewTextBoxColumn.Name = "codeClasseDataGridViewTextBoxColumn";
            this.codeClasseDataGridViewTextBoxColumn.Width = 150;
            // 
            // classeDataGridViewTextBoxColumn
            // 
            this.classeDataGridViewTextBoxColumn.DataPropertyName = "Classe";
            this.classeDataGridViewTextBoxColumn.HeaderText = "Nom de la classe";
            this.classeDataGridViewTextBoxColumn.Name = "classeDataGridViewTextBoxColumn";
            this.classeDataGridViewTextBoxColumn.Width = 180;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataSource = typeof(MetroUI.Class);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(21, 56);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Classe : ";
            // 
            // txtCodeClasse
            // 
            // 
            // 
            // 
            this.txtCodeClasse.CustomButton.Image = null;
            this.txtCodeClasse.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.txtCodeClasse.CustomButton.Name = "";
            this.txtCodeClasse.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodeClasse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodeClasse.CustomButton.TabIndex = 1;
            this.txtCodeClasse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodeClasse.CustomButton.UseSelectable = true;
            this.txtCodeClasse.CustomButton.Visible = false;
            this.txtCodeClasse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classBindingSource, "CodeClasse", true));
            this.txtCodeClasse.Lines = new string[0];
            this.txtCodeClasse.Location = new System.Drawing.Point(118, 19);
            this.txtCodeClasse.MaxLength = 32767;
            this.txtCodeClasse.Name = "txtCodeClasse";
            this.txtCodeClasse.PasswordChar = '\0';
            this.txtCodeClasse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodeClasse.SelectedText = "";
            this.txtCodeClasse.SelectionLength = 0;
            this.txtCodeClasse.SelectionStart = 0;
            this.txtCodeClasse.ShortcutsEnabled = true;
            this.txtCodeClasse.Size = new System.Drawing.Size(84, 23);
            this.txtCodeClasse.TabIndex = 0;
            this.txtCodeClasse.UseSelectable = true;
            this.txtCodeClasse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodeClasse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtClasse
            // 
            // 
            // 
            // 
            this.txtClasse.CustomButton.Image = null;
            this.txtClasse.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.txtClasse.CustomButton.Name = "";
            this.txtClasse.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtClasse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClasse.CustomButton.TabIndex = 1;
            this.txtClasse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClasse.CustomButton.UseSelectable = true;
            this.txtClasse.CustomButton.Visible = false;
            this.txtClasse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classBindingSource, "Classe", true));
            this.txtClasse.Lines = new string[0];
            this.txtClasse.Location = new System.Drawing.Point(118, 56);
            this.txtClasse.MaxLength = 32767;
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.PasswordChar = '\0';
            this.txtClasse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClasse.SelectedText = "";
            this.txtClasse.SelectionLength = 0;
            this.txtClasse.SelectionStart = 0;
            this.txtClasse.ShortcutsEnabled = true;
            this.txtClasse.Size = new System.Drawing.Size(219, 23);
            this.txtClasse.TabIndex = 1;
            this.txtClasse.UseSelectable = true;
            this.txtClasse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClasse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnEnregistrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnregistrer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(90, 219);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(86, 54);
            this.btnEnregistrer.TabIndex = 2;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(182, 219);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(83, 54);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(271, 219);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 54);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnNouveau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNouveau.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(9, 219);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(75, 54);
            this.btnNouveau.TabIndex = 1;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.txtCodeClasse);
            this.panel.Controls.Add(this.metroLabel1);
            this.panel.Controls.Add(this.metroLabel2);
            this.panel.Controls.Add(this.txtClasse);
            this.panel.Location = new System.Drawing.Point(9, 75);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(345, 100);
            this.panel.TabIndex = 0;
            // 
            // frmClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 365);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.metroGridClasse);
            this.MaximizeBox = false;
            this.Name = "frmClasse";
            this.Text = "Liste complète des classes";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmClasse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridClasse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid metroGridClasse;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtCodeClasse;
        private MetroFramework.Controls.MetroTextBox txtClasse;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.BindingSource classBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeClasseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classeDataGridViewTextBoxColumn;
    }
}