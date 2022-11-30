namespace MetroUI
{
    partial class frmListeEleve
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
            this.metroGridListeEleves = new MetroFramework.Controls.MetroGrid();
            this.matriculeElDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postNomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeClasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eleveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtRechercher = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnRaffraichir = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtLblTotal = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridListeEleves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGridListeEleves
            // 
            this.metroGridListeEleves.AllowUserToAddRows = false;
            this.metroGridListeEleves.AllowUserToResizeRows = false;
            this.metroGridListeEleves.AutoGenerateColumns = false;
            this.metroGridListeEleves.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridListeEleves.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridListeEleves.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridListeEleves.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridListeEleves.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridListeEleves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridListeEleves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculeElDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.postNomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.codeClasseDataGridViewTextBoxColumn,
            this.dateNaissanceDataGridViewTextBoxColumn,
            this.sexeDataGridViewTextBoxColumn});
            this.metroGridListeEleves.DataSource = this.eleveBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridListeEleves.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridListeEleves.EnableHeadersVisualStyles = false;
            this.metroGridListeEleves.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridListeEleves.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridListeEleves.Location = new System.Drawing.Point(23, 122);
            this.metroGridListeEleves.Name = "metroGridListeEleves";
            this.metroGridListeEleves.ReadOnly = true;
            this.metroGridListeEleves.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridListeEleves.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridListeEleves.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridListeEleves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridListeEleves.Size = new System.Drawing.Size(781, 521);
            this.metroGridListeEleves.Style = MetroFramework.MetroColorStyle.Green;
            this.metroGridListeEleves.TabIndex = 0;
            this.metroGridListeEleves.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridListeEleves_CellContentDoubleClick);
            // 
            // matriculeElDataGridViewTextBoxColumn
            // 
            this.matriculeElDataGridViewTextBoxColumn.DataPropertyName = "MatriculeEl";
            this.matriculeElDataGridViewTextBoxColumn.HeaderText = "MATRICULE";
            this.matriculeElDataGridViewTextBoxColumn.Name = "matriculeElDataGridViewTextBoxColumn";
            this.matriculeElDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "NOM";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postNomDataGridViewTextBoxColumn
            // 
            this.postNomDataGridViewTextBoxColumn.DataPropertyName = "PostNom";
            this.postNomDataGridViewTextBoxColumn.HeaderText = "POSTNOM";
            this.postNomDataGridViewTextBoxColumn.Name = "postNomDataGridViewTextBoxColumn";
            this.postNomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "PRENOM";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeClasseDataGridViewTextBoxColumn
            // 
            this.codeClasseDataGridViewTextBoxColumn.DataPropertyName = "CodeClasse";
            this.codeClasseDataGridViewTextBoxColumn.HeaderText = "CODE CLASSE";
            this.codeClasseDataGridViewTextBoxColumn.Name = "codeClasseDataGridViewTextBoxColumn";
            this.codeClasseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateNaissanceDataGridViewTextBoxColumn
            // 
            this.dateNaissanceDataGridViewTextBoxColumn.DataPropertyName = "DateNaissance";
            this.dateNaissanceDataGridViewTextBoxColumn.HeaderText = "DATE NAISSANCE";
            this.dateNaissanceDataGridViewTextBoxColumn.Name = "dateNaissanceDataGridViewTextBoxColumn";
            this.dateNaissanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateNaissanceDataGridViewTextBoxColumn.Width = 150;
            // 
            // sexeDataGridViewTextBoxColumn
            // 
            this.sexeDataGridViewTextBoxColumn.DataPropertyName = "Sexe";
            this.sexeDataGridViewTextBoxColumn.HeaderText = "SEXE";
            this.sexeDataGridViewTextBoxColumn.Name = "sexeDataGridViewTextBoxColumn";
            this.sexeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eleveBindingSource
            // 
            this.eleveBindingSource.DataSource = typeof(MetroUI.Eleve);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(37, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recherche :";
            // 
            // txtRechercher
            // 
            this.txtRechercher.Depth = 0;
            this.txtRechercher.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRechercher.Hint = "Taper ici le nom, la classe, le code, le sexe ou la date de naissance de l\'élève " +
    "...";
            this.txtRechercher.Location = new System.Drawing.Point(137, 66);
            this.txtRechercher.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.PasswordChar = '\0';
            this.txtRechercher.SelectedText = "";
            this.txtRechercher.SelectionLength = 0;
            this.txtRechercher.SelectionStart = 0;
            this.txtRechercher.Size = new System.Drawing.Size(537, 23);
            this.txtRechercher.TabIndex = 3;
            this.txtRechercher.UseSystemPasswordChar = false;
            this.txtRechercher.TextChanged += new System.EventHandler(this.txtRechercher_TextChanged);
            // 
            // btnRaffraichir
            // 
            this.btnRaffraichir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRaffraichir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaffraichir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaffraichir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnRaffraichir.Location = new System.Drawing.Point(708, 57);
            this.btnRaffraichir.Name = "btnRaffraichir";
            this.btnRaffraichir.Size = new System.Drawing.Size(96, 44);
            this.btnRaffraichir.TabIndex = 4;
            this.btnRaffraichir.Text = "&Raffraîchir";
            this.btnRaffraichir.UseVisualStyleBackColor = true;
            this.btnRaffraichir.Click += new System.EventHandler(this.btnRaffraichir_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(451, 659);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Total trouvé :";
            // 
            // mtLblTotal
            // 
            this.mtLblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtLblTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mtLblTotal.Location = new System.Drawing.Point(537, 659);
            this.mtLblTotal.Name = "mtLblTotal";
            this.mtLblTotal.Size = new System.Drawing.Size(46, 22);
            this.mtLblTotal.TabIndex = 5;
            this.mtLblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmListeEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 695);
            this.Controls.Add(this.mtLblTotal);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnRaffraichir);
            this.Controls.Add(this.txtRechercher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroGridListeEleves);
            this.Name = "frmListeEleve";
            this.Text = "Liste complète des élèves inscrits";
            this.Load += new System.EventHandler(this.frmListeEleve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridListeEleves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleveBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGridListeEleves;
        private System.Windows.Forms.BindingSource eleveBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculeElDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postNomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeClasseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNaissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRechercher;
        private System.Windows.Forms.Button btnRaffraichir;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel mtLblTotal;
    }
}