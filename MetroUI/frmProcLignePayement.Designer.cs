namespace MetroUI
{
    partial class frmProcLignePayement
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
            this.btnRadioPayeAujourd = new System.Windows.Forms.RadioButton();
            this.groupBoxFiltre = new System.Windows.Forms.GroupBox();
            this.cboMois = new System.Windows.Forms.ComboBox();
            this.moisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtApres = new System.Windows.Forms.DateTimePicker();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDebut = new System.Windows.Forms.DateTimePicker();
            this.btnRadioParMois = new System.Windows.Forms.RadioButton();
            this.btnRadioFiltreAyantPayer = new System.Windows.Forms.RadioButton();
            this.btnRadioFiltreEntre = new System.Windows.Forms.RadioButton();
            this.metroPanel = new MetroFramework.Controls.MetroPanel();
            this.mtLblTotal = new MetroFramework.Controls.MetroLabel();
            this.metroLabelTotalTrouve = new MetroFramework.Controls.MetroLabel();
            this.metroGrid = new MetroFramework.Controls.MetroGrid();
            this.matriculeElDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postNomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePayeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleMoisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewLignePayementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroTileRaffraichir = new MetroFramework.Controls.MetroTile();
            this.metroTileFiltrer = new MetroFramework.Controls.MetroTile();
            this.groupBoxFiltre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moisBindingSource)).BeginInit();
            this.metroPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLignePayementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRadioPayeAujourd
            // 
            this.btnRadioPayeAujourd.AutoSize = true;
            this.btnRadioPayeAujourd.Location = new System.Drawing.Point(6, 19);
            this.btnRadioPayeAujourd.Name = "btnRadioPayeAujourd";
            this.btnRadioPayeAujourd.Size = new System.Drawing.Size(227, 21);
            this.btnRadioPayeAujourd.TabIndex = 1;
            this.btnRadioPayeAujourd.TabStop = true;
            this.btnRadioPayeAujourd.Text = "Elève qui ont payés aujourd\'hui";
            this.btnRadioPayeAujourd.UseVisualStyleBackColor = true;
            // 
            // groupBoxFiltre
            // 
            this.groupBoxFiltre.Controls.Add(this.cboMois);
            this.groupBoxFiltre.Controls.Add(this.dtApres);
            this.groupBoxFiltre.Controls.Add(this.dtFin);
            this.groupBoxFiltre.Controls.Add(this.label1);
            this.groupBoxFiltre.Controls.Add(this.dtDebut);
            this.groupBoxFiltre.Controls.Add(this.btnRadioParMois);
            this.groupBoxFiltre.Controls.Add(this.btnRadioFiltreAyantPayer);
            this.groupBoxFiltre.Controls.Add(this.btnRadioFiltreEntre);
            this.groupBoxFiltre.Controls.Add(this.btnRadioPayeAujourd);
            this.groupBoxFiltre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltre.Location = new System.Drawing.Point(52, 511);
            this.groupBoxFiltre.Name = "groupBoxFiltre";
            this.groupBoxFiltre.Size = new System.Drawing.Size(561, 150);
            this.groupBoxFiltre.TabIndex = 2;
            this.groupBoxFiltre.TabStop = false;
            this.groupBoxFiltre.Text = "Filtre";
            // 
            // cboMois
            // 
            this.cboMois.DataSource = this.moisBindingSource;
            this.cboMois.DisplayMember = "LibelleMois";
            this.cboMois.FormattingEnabled = true;
            this.cboMois.Location = new System.Drawing.Point(271, 109);
            this.cboMois.Name = "cboMois";
            this.cboMois.Size = new System.Drawing.Size(105, 25);
            this.cboMois.TabIndex = 9;
            this.cboMois.ValueMember = "CodeMois";
            // 
            // moisBindingSource
            // 
            this.moisBindingSource.DataSource = typeof(MetroUI.Mois);
            // 
            // dtApres
            // 
            this.dtApres.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtApres.Location = new System.Drawing.Point(220, 77);
            this.dtApres.Name = "dtApres";
            this.dtApres.Size = new System.Drawing.Size(99, 23);
            this.dtApres.TabIndex = 8;
            // 
            // dtFin
            // 
            this.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFin.Location = new System.Drawing.Point(397, 45);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(99, 23);
            this.dtFin.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "et le : ";
            // 
            // dtDebut
            // 
            this.dtDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDebut.Location = new System.Drawing.Point(220, 45);
            this.dtDebut.Name = "dtDebut";
            this.dtDebut.Size = new System.Drawing.Size(99, 23);
            this.dtDebut.TabIndex = 5;
            // 
            // btnRadioParMois
            // 
            this.btnRadioParMois.AutoSize = true;
            this.btnRadioParMois.Location = new System.Drawing.Point(6, 109);
            this.btnRadioParMois.Name = "btnRadioParMois";
            this.btnRadioParMois.Size = new System.Drawing.Size(259, 21);
            this.btnRadioParMois.TabIndex = 4;
            this.btnRadioParMois.TabStop = true;
            this.btnRadioParMois.Text = "Elèves ayant payés pour le mois de :";
            this.btnRadioParMois.UseVisualStyleBackColor = true;
            // 
            // btnRadioFiltreAyantPayer
            // 
            this.btnRadioFiltreAyantPayer.AutoSize = true;
            this.btnRadioFiltreAyantPayer.Location = new System.Drawing.Point(7, 80);
            this.btnRadioFiltreAyantPayer.Name = "btnRadioFiltreAyantPayer";
            this.btnRadioFiltreAyantPayer.Size = new System.Drawing.Size(166, 21);
            this.btnRadioFiltreAyantPayer.TabIndex = 3;
            this.btnRadioFiltreAyantPayer.TabStop = true;
            this.btnRadioFiltreAyantPayer.Text = "Ayant payés après le :";
            this.btnRadioFiltreAyantPayer.UseVisualStyleBackColor = true;
            // 
            // btnRadioFiltreEntre
            // 
            this.btnRadioFiltreEntre.AutoSize = true;
            this.btnRadioFiltreEntre.Location = new System.Drawing.Point(7, 48);
            this.btnRadioFiltreEntre.Name = "btnRadioFiltreEntre";
            this.btnRadioFiltreEntre.Size = new System.Drawing.Size(207, 21);
            this.btnRadioFiltreEntre.TabIndex = 2;
            this.btnRadioFiltreEntre.TabStop = true;
            this.btnRadioFiltreEntre.Text = "Elèves ayant payés entre le :";
            this.btnRadioFiltreEntre.UseVisualStyleBackColor = true;
            // 
            // metroPanel
            // 
            this.metroPanel.Controls.Add(this.mtLblTotal);
            this.metroPanel.Controls.Add(this.metroLabelTotalTrouve);
            this.metroPanel.Controls.Add(this.metroGrid);
            this.metroPanel.HorizontalScrollbarBarColor = true;
            this.metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel.HorizontalScrollbarSize = 10;
            this.metroPanel.Location = new System.Drawing.Point(14, 63);
            this.metroPanel.Name = "metroPanel";
            this.metroPanel.Size = new System.Drawing.Size(825, 442);
            this.metroPanel.TabIndex = 3;
            this.metroPanel.VerticalScrollbarBarColor = true;
            this.metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel.VerticalScrollbarSize = 10;
            // 
            // mtLblTotal
            // 
            this.mtLblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtLblTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mtLblTotal.Location = new System.Drawing.Point(441, 401);
            this.mtLblTotal.Name = "mtLblTotal";
            this.mtLblTotal.Size = new System.Drawing.Size(46, 22);
            this.mtLblTotal.TabIndex = 6;
            this.mtLblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabelTotalTrouve
            // 
            this.metroLabelTotalTrouve.AutoSize = true;
            this.metroLabelTotalTrouve.Location = new System.Drawing.Point(355, 401);
            this.metroLabelTotalTrouve.Name = "metroLabelTotalTrouve";
            this.metroLabelTotalTrouve.Size = new System.Drawing.Size(84, 19);
            this.metroLabelTotalTrouve.TabIndex = 7;
            this.metroLabelTotalTrouve.Text = "Total trouvé :";
            // 
            // metroGrid
            // 
            this.metroGrid.AllowUserToAddRows = false;
            this.metroGrid.AllowUserToResizeRows = false;
            this.metroGrid.AutoGenerateColumns = false;
            this.metroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculeElDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.postNomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.classeDataGridViewTextBoxColumn,
            this.datePayeDataGridViewTextBoxColumn,
            this.montantDataGridViewTextBoxColumn,
            this.libelleMoisDataGridViewTextBoxColumn});
            this.metroGrid.DataSource = this.viewLignePayementBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid.EnableHeadersVisualStyles = false;
            this.metroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.Location = new System.Drawing.Point(9, 13);
            this.metroGrid.Name = "metroGrid";
            this.metroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid.Size = new System.Drawing.Size(813, 368);
            this.metroGrid.TabIndex = 4;
            // 
            // matriculeElDataGridViewTextBoxColumn
            // 
            this.matriculeElDataGridViewTextBoxColumn.DataPropertyName = "MatriculeEl";
            this.matriculeElDataGridViewTextBoxColumn.HeaderText = "MATRICULE";
            this.matriculeElDataGridViewTextBoxColumn.Name = "matriculeElDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "NOM";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // postNomDataGridViewTextBoxColumn
            // 
            this.postNomDataGridViewTextBoxColumn.DataPropertyName = "PostNom";
            this.postNomDataGridViewTextBoxColumn.HeaderText = "POSTNOM";
            this.postNomDataGridViewTextBoxColumn.Name = "postNomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "PRENOM";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // classeDataGridViewTextBoxColumn
            // 
            this.classeDataGridViewTextBoxColumn.DataPropertyName = "Classe";
            this.classeDataGridViewTextBoxColumn.HeaderText = "CLASSE";
            this.classeDataGridViewTextBoxColumn.Name = "classeDataGridViewTextBoxColumn";
            this.classeDataGridViewTextBoxColumn.Width = 80;
            // 
            // datePayeDataGridViewTextBoxColumn
            // 
            this.datePayeDataGridViewTextBoxColumn.DataPropertyName = "DatePaye";
            this.datePayeDataGridViewTextBoxColumn.HeaderText = "DATE";
            this.datePayeDataGridViewTextBoxColumn.Name = "datePayeDataGridViewTextBoxColumn";
            // 
            // montantDataGridViewTextBoxColumn
            // 
            this.montantDataGridViewTextBoxColumn.DataPropertyName = "Montant";
            this.montantDataGridViewTextBoxColumn.HeaderText = "MONTANT";
            this.montantDataGridViewTextBoxColumn.Name = "montantDataGridViewTextBoxColumn";
            // 
            // libelleMoisDataGridViewTextBoxColumn
            // 
            this.libelleMoisDataGridViewTextBoxColumn.DataPropertyName = "LibelleMois";
            this.libelleMoisDataGridViewTextBoxColumn.HeaderText = "LIBELLE";
            this.libelleMoisDataGridViewTextBoxColumn.Name = "libelleMoisDataGridViewTextBoxColumn";
            // 
            // viewLignePayementBindingSource
            // 
            this.viewLignePayementBindingSource.DataSource = typeof(MetroUI.ViewLignePayement);
            // 
            // metroTileRaffraichir
            // 
            this.metroTileRaffraichir.ActiveControl = null;
            this.metroTileRaffraichir.Location = new System.Drawing.Point(639, 612);
            this.metroTileRaffraichir.Name = "metroTileRaffraichir";
            this.metroTileRaffraichir.Size = new System.Drawing.Size(80, 55);
            this.metroTileRaffraichir.TabIndex = 5;
            this.metroTileRaffraichir.Text = "&Raffraîchir";
            this.metroTileRaffraichir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileRaffraichir.UseSelectable = true;
            this.metroTileRaffraichir.Click += new System.EventHandler(this.metroTileRaffraichir_Click);
            // 
            // metroTileFiltrer
            // 
            this.metroTileFiltrer.ActiveControl = null;
            this.metroTileFiltrer.Location = new System.Drawing.Point(639, 530);
            this.metroTileFiltrer.Name = "metroTileFiltrer";
            this.metroTileFiltrer.Size = new System.Drawing.Size(80, 59);
            this.metroTileFiltrer.TabIndex = 6;
            this.metroTileFiltrer.Text = "&Filtrer";
            this.metroTileFiltrer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileFiltrer.UseSelectable = true;
            this.metroTileFiltrer.Click += new System.EventHandler(this.metroTileFiltrer_Click);
            // 
            // frmProcLignePayement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 690);
            this.Controls.Add(this.metroTileFiltrer);
            this.Controls.Add(this.metroPanel);
            this.Controls.Add(this.groupBoxFiltre);
            this.Controls.Add(this.metroTileRaffraichir);
            this.MaximizeBox = false;
            this.Name = "frmProcLignePayement";
            this.Text = "Ligne payement";
            this.Load += new System.EventHandler(this.frmProcLignePayement_Load);
            this.groupBoxFiltre.ResumeLayout(false);
            this.groupBoxFiltre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moisBindingSource)).EndInit();
            this.metroPanel.ResumeLayout(false);
            this.metroPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewLignePayementBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton btnRadioPayeAujourd;
        private System.Windows.Forms.GroupBox groupBoxFiltre;
        private System.Windows.Forms.ComboBox cboMois;
        private System.Windows.Forms.DateTimePicker dtApres;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDebut;
        private System.Windows.Forms.RadioButton btnRadioParMois;
        private System.Windows.Forms.RadioButton btnRadioFiltreAyantPayer;
        private System.Windows.Forms.RadioButton btnRadioFiltreEntre;
        private MetroFramework.Controls.MetroPanel metroPanel;
        private MetroFramework.Controls.MetroTile metroTileRaffraichir;
        private MetroFramework.Controls.MetroGrid metroGrid;
        private System.Windows.Forms.BindingSource viewLignePayementBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculeElDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postNomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePayeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleMoisDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTile metroTileFiltrer;
        private System.Windows.Forms.BindingSource moisBindingSource;
        private MetroFramework.Controls.MetroLabel mtLblTotal;
        private MetroFramework.Controls.MetroLabel metroLabelTotalTrouve;
    }
}