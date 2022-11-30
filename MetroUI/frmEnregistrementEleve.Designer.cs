namespace MetroUI
{
    partial class frmEnregistrementEleve
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
            this.panel = new MetroFramework.Controls.MetroPanel();
            this.mtCboCodeClasse = new System.Windows.Forms.ComboBox();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cboGenre = new MetroFramework.Controls.MetroComboBox();
            this.eleveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtDateNaissance = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtPrenom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPostNom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMatricule = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CbGenre = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.linkLabelListeEleve = new System.Windows.Forms.LinkLabel();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEditer = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.mtCboCodeClasse);
            this.panel.Controls.Add(this.metroLabel7);
            this.panel.Controls.Add(this.cboGenre);
            this.panel.Controls.Add(this.mtDateNaissance);
            this.panel.Controls.Add(this.metroLabel6);
            this.panel.Controls.Add(this.metroLabel5);
            this.panel.Controls.Add(this.metroLabel4);
            this.panel.Controls.Add(this.metroLabel3);
            this.panel.Controls.Add(this.metroLabel2);
            this.panel.Controls.Add(this.metroLabel1);
            this.panel.Controls.Add(this.txtPrenom);
            this.panel.Controls.Add(this.txtPostNom);
            this.panel.Controls.Add(this.txtNom);
            this.panel.Controls.Add(this.txtMatricule);
            this.panel.HorizontalScrollbarBarColor = true;
            this.panel.HorizontalScrollbarHighlightOnWheel = false;
            this.panel.HorizontalScrollbarSize = 10;
            this.panel.Location = new System.Drawing.Point(8, 63);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(570, 208);
            this.panel.TabIndex = 0;
            this.panel.VerticalScrollbarBarColor = true;
            this.panel.VerticalScrollbarHighlightOnWheel = false;
            this.panel.VerticalScrollbarSize = 10;
            // 
            // mtCboCodeClasse
            // 
            this.mtCboCodeClasse.DataSource = this.classBindingSource;
            this.mtCboCodeClasse.DisplayMember = "CodeClasse";
            this.mtCboCodeClasse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtCboCodeClasse.FormattingEnabled = true;
            this.mtCboCodeClasse.Location = new System.Drawing.Point(127, 100);
            this.mtCboCodeClasse.Name = "mtCboCodeClasse";
            this.mtCboCodeClasse.Size = new System.Drawing.Size(102, 25);
            this.mtCboCodeClasse.TabIndex = 4;
            this.mtCboCodeClasse.ValueMember = "CodeClasse";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataSource = typeof(MetroUI.Class);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(3, 100);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(84, 19);
            this.metroLabel7.TabIndex = 27;
            this.metroLabel7.Text = "CodeClasse :";
            // 
            // cboGenre
            // 
            this.cboGenre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eleveBindingSource, "Sexe", true));
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.ItemHeight = 23;
            this.cboGenre.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cboGenre.Location = new System.Drawing.Point(353, 100);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(56, 29);
            this.cboGenre.TabIndex = 5;
            this.cboGenre.UseSelectable = true;
            // 
            // eleveBindingSource
            // 
            this.eleveBindingSource.DataSource = typeof(MetroUI.Eleve);
            // 
            // mtDateNaissance
            // 
            this.mtDateNaissance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eleveBindingSource, "DateNaissance", true));
            this.mtDateNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mtDateNaissance.Location = new System.Drawing.Point(127, 152);
            this.mtDateNaissance.MaxDate = new System.DateTime(2008, 12, 31, 0, 0, 0, 0);
            this.mtDateNaissance.MinDate = new System.DateTime(1990, 2, 1, 0, 0, 0, 0);
            this.mtDateNaissance.MinimumSize = new System.Drawing.Size(0, 29);
            this.mtDateNaissance.Name = "mtDateNaissance";
            this.mtDateNaissance.Size = new System.Drawing.Size(97, 29);
            this.mtDateNaissance.TabIndex = 6;
            this.mtDateNaissance.Value = new System.DateTime(2008, 1, 31, 0, 0, 0, 0);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(276, 102);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(51, 19);
            this.metroLabel6.TabIndex = 23;
            this.metroLabel6.Text = "Genre :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(276, 62);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(63, 19);
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "Prénom :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 58);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Postnom :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(276, 20);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 19;
            this.metroLabel3.Text = "Nom :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 20);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Matricule :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 152);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(120, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Date de naissance :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eleveBindingSource, "Prenom", true));
            this.txtPrenom.Depth = 0;
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Hint = "Prénom élève";
            this.txtPrenom.Location = new System.Drawing.Point(353, 62);
            this.txtPrenom.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.PasswordChar = '\0';
            this.txtPrenom.SelectedText = "";
            this.txtPrenom.SelectionLength = 0;
            this.txtPrenom.SelectionStart = 0;
            this.txtPrenom.Size = new System.Drawing.Size(110, 23);
            this.txtPrenom.TabIndex = 3;
            this.txtPrenom.UseSystemPasswordChar = false;
            // 
            // txtPostNom
            // 
            this.txtPostNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eleveBindingSource, "PostNom", true));
            this.txtPostNom.Depth = 0;
            this.txtPostNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostNom.Hint = "Postnom élève";
            this.txtPostNom.Location = new System.Drawing.Point(129, 59);
            this.txtPostNom.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPostNom.Name = "txtPostNom";
            this.txtPostNom.PasswordChar = '\0';
            this.txtPostNom.SelectedText = "";
            this.txtPostNom.SelectionLength = 0;
            this.txtPostNom.SelectionStart = 0;
            this.txtPostNom.Size = new System.Drawing.Size(135, 23);
            this.txtPostNom.TabIndex = 2;
            this.txtPostNom.UseSystemPasswordChar = false;
            // 
            // txtNom
            // 
            this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eleveBindingSource, "Nom", true));
            this.txtNom.Depth = 0;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Hint = "Nom élève";
            this.txtNom.Location = new System.Drawing.Point(353, 20);
            this.txtNom.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.SelectedText = "";
            this.txtNom.SelectionLength = 0;
            this.txtNom.SelectionStart = 0;
            this.txtNom.Size = new System.Drawing.Size(187, 23);
            this.txtNom.TabIndex = 1;
            this.txtNom.UseSystemPasswordChar = false;
            // 
            // txtMatricule
            // 
            this.txtMatricule.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMatricule.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eleveBindingSource, "MatriculeEl", true));
            this.txtMatricule.Depth = 0;
            this.txtMatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricule.ForeColor = System.Drawing.Color.Red;
            this.txtMatricule.Hint = "Matricule";
            this.txtMatricule.Location = new System.Drawing.Point(129, 20);
            this.txtMatricule.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.PasswordChar = '\0';
            this.txtMatricule.SelectedText = "";
            this.txtMatricule.SelectionLength = 0;
            this.txtMatricule.SelectionStart = 0;
            this.txtMatricule.Size = new System.Drawing.Size(110, 23);
            this.txtMatricule.TabIndex = 0;
            this.txtMatricule.UseSystemPasswordChar = false;
            // 
            // CbGenre
            // 
            this.CbGenre.AutoSize = true;
            this.CbGenre.Depth = 0;
            this.CbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CbGenre.Location = new System.Drawing.Point(129, 209);
            this.CbGenre.Margin = new System.Windows.Forms.Padding(0);
            this.CbGenre.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CbGenre.MouseState = MaterialSkin.MouseState.HOVER;
            this.CbGenre.Name = "CbGenre";
            this.CbGenre.Ripple = true;
            this.CbGenre.Size = new System.Drawing.Size(43, 30);
            this.CbGenre.TabIndex = 22;
            this.CbGenre.Text = "??";
            this.CbGenre.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.PaleGreen;
            this.btnEnregistrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnregistrer.FlatAppearance.BorderSize = 0;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnregistrer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(379, 280);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(86, 42);
            this.btnEnregistrer.TabIndex = 4;
            this.btnEnregistrer.Text = "&Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.BackColor = System.Drawing.Color.PaleGreen;
            this.btnNouveau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNouveau.FlatAppearance.BorderSize = 0;
            this.btnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNouveau.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(212, 280);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(79, 42);
            this.btnNouveau.TabIndex = 2;
            this.btnNouveau.Text = "&Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // linkLabelListeEleve
            // 
            this.linkLabelListeEleve.AutoSize = true;
            this.linkLabelListeEleve.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelListeEleve.LinkColor = System.Drawing.Color.Blue;
            this.linkLabelListeEleve.Location = new System.Drawing.Point(24, 295);
            this.linkLabelListeEleve.Name = "linkLabelListeEleve";
            this.linkLabelListeEleve.Size = new System.Drawing.Size(156, 16);
            this.linkLabelListeEleve.TabIndex = 1;
            this.linkLabelListeEleve.TabStop = true;
            this.linkLabelListeEleve.Text = "Afficher tous les élèves";
            this.linkLabelListeEleve.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelListeEleve_LinkClicked);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnnuler.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(297, 280);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(76, 42);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "&Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEditer
            // 
            this.btnEditer.BackColor = System.Drawing.Color.PaleGreen;
            this.btnEditer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditer.Location = new System.Drawing.Point(472, 280);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Size = new System.Drawing.Size(73, 42);
            this.btnEditer.TabIndex = 5;
            this.btnEditer.Text = "E&diter";
            this.btnEditer.UseVisualStyleBackColor = false;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // frmEnregistrementEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(587, 346);
            this.Controls.Add(this.btnEditer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.linkLabelListeEleve);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.btnEnregistrer);
            this.MaximizeBox = false;
            this.Name = "frmEnregistrementEleve";
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Enregistrement élève";
            this.Load += new System.EventHandler(this.frmEnregistrementEleve_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleveBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroPanel panel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrenom;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPostNom;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNom;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMatricule;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnNouveau;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MaterialSkin.Controls.MaterialCheckBox CbGenre;
        private MetroFramework.Controls.MetroDateTime mtDateNaissance;
        private System.Windows.Forms.LinkLabel linkLabelListeEleve;
        private MetroFramework.Controls.MetroComboBox cboGenre;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.BindingSource eleveBindingSource;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.BindingSource classBindingSource;
        private System.Windows.Forms.Button btnEditer;
        private System.Windows.Forms.ComboBox mtCboCodeClasse;
    }
}