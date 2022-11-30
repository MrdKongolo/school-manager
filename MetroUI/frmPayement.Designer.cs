namespace MetroUI
{
    partial class frmPayement
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
            this.panelGauche = new System.Windows.Forms.Panel();
            this.panelDroit = new System.Windows.Forms.Panel();
            this.metroTileEnregistrer = new MetroFramework.Controls.MetroTile();
            this.metroTileAnnuler = new MetroFramework.Controls.MetroTile();
            this.metroTileImprimer = new MetroFramework.Controls.MetroTile();
            this.panelEntete = new System.Windows.Forms.Panel();
            this.lblFermer = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.cboTestMatricule = new System.Windows.Forms.ComboBox();
            this.eleveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.txtClasse = new System.Windows.Forms.TextBox();
            this.cboNumRecu = new System.Windows.Forms.ComboBox();
            this.txtFraisID = new System.Windows.Forms.TextBox();
            this.fraiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.cboFrais = new System.Windows.Forms.ComboBox();
            this.cboMois = new System.Windows.Forms.ComboBox();
            this.moisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtPostnom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.cboMatricule = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.payeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelDroit.SuspendLayout();
            this.panelEntete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eleveBindingSource)).BeginInit();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fraiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGauche
            // 
            this.panelGauche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panelGauche.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGauche.Location = new System.Drawing.Point(0, 0);
            this.panelGauche.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelGauche.Name = "panelGauche";
            this.panelGauche.Size = new System.Drawing.Size(134, 349);
            this.panelGauche.TabIndex = 0;
            // 
            // panelDroit
            // 
            this.panelDroit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDroit.Controls.Add(this.metroTileEnregistrer);
            this.panelDroit.Controls.Add(this.metroTileAnnuler);
            this.panelDroit.Controls.Add(this.metroTileImprimer);
            this.panelDroit.Controls.Add(this.panelEntete);
            this.panelDroit.Controls.Add(this.panelCentral);
            this.panelDroit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDroit.Location = new System.Drawing.Point(134, 0);
            this.panelDroit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDroit.Name = "panelDroit";
            this.panelDroit.Size = new System.Drawing.Size(773, 349);
            this.panelDroit.TabIndex = 1;
            // 
            // metroTileEnregistrer
            // 
            this.metroTileEnregistrer.ActiveControl = null;
            this.metroTileEnregistrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileEnregistrer.Location = new System.Drawing.Point(427, 292);
            this.metroTileEnregistrer.Name = "metroTileEnregistrer";
            this.metroTileEnregistrer.Size = new System.Drawing.Size(86, 43);
            this.metroTileEnregistrer.TabIndex = 2;
            this.metroTileEnregistrer.Text = "&Enregistrer";
            this.metroTileEnregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileEnregistrer.UseSelectable = true;
            this.metroTileEnregistrer.Click += new System.EventHandler(this.metroTileEnregistrer_Click);
            // 
            // metroTileAnnuler
            // 
            this.metroTileAnnuler.ActiveControl = null;
            this.metroTileAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileAnnuler.Location = new System.Drawing.Point(555, 292);
            this.metroTileAnnuler.Name = "metroTileAnnuler";
            this.metroTileAnnuler.Size = new System.Drawing.Size(86, 43);
            this.metroTileAnnuler.TabIndex = 3;
            this.metroTileAnnuler.Text = "&Annuler";
            this.metroTileAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAnnuler.UseSelectable = true;
            this.metroTileAnnuler.Click += new System.EventHandler(this.metroTileAnnuler_Click);
            // 
            // metroTileImprimer
            // 
            this.metroTileImprimer.ActiveControl = null;
            this.metroTileImprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTileImprimer.Location = new System.Drawing.Point(672, 292);
            this.metroTileImprimer.Name = "metroTileImprimer";
            this.metroTileImprimer.Size = new System.Drawing.Size(86, 43);
            this.metroTileImprimer.TabIndex = 4;
            this.metroTileImprimer.Text = "Im&primer";
            this.metroTileImprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileImprimer.UseSelectable = true;
            this.metroTileImprimer.Click += new System.EventHandler(this.metroTileImprimer_Click);
            // 
            // panelEntete
            // 
            this.panelEntete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panelEntete.Controls.Add(this.lblFermer);
            this.panelEntete.Controls.Add(this.btnValider);
            this.panelEntete.Controls.Add(this.cboTestMatricule);
            this.panelEntete.Controls.Add(this.label1);
            this.panelEntete.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEntete.Location = new System.Drawing.Point(0, 0);
            this.panelEntete.Name = "panelEntete";
            this.panelEntete.Size = new System.Drawing.Size(773, 56);
            this.panelEntete.TabIndex = 0;
            // 
            // lblFermer
            // 
            this.lblFermer.AutoSize = true;
            this.lblFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFermer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFermer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFermer.Location = new System.Drawing.Point(746, 9);
            this.lblFermer.Name = "lblFermer";
            this.lblFermer.Size = new System.Drawing.Size(17, 16);
            this.lblFermer.TabIndex = 2;
            this.lblFermer.Text = "X";
            this.lblFermer.Click += new System.EventHandler(this.lblFermer_Click);
            // 
            // btnValider
            // 
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValider.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnValider.Location = new System.Drawing.Point(515, 14);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 28);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // cboTestMatricule
            // 
            this.cboTestMatricule.DataSource = this.eleveBindingSource;
            this.cboTestMatricule.DisplayMember = "MatriculeEl";
            this.cboTestMatricule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboTestMatricule.FormattingEnabled = true;
            this.cboTestMatricule.Location = new System.Drawing.Point(324, 16);
            this.cboTestMatricule.Name = "cboTestMatricule";
            this.cboTestMatricule.Size = new System.Drawing.Size(176, 24);
            this.cboTestMatricule.TabIndex = 0;
            this.cboTestMatricule.ValueMember = "MatriculeEl";
            // 
            // eleveBindingSource
            // 
            this.eleveBindingSource.DataSource = typeof(MetroUI.Eleve);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(171, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Entrez ici le matricule ";
            // 
            // panelCentral
            // 
            this.panelCentral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCentral.Controls.Add(this.txtClasse);
            this.panelCentral.Controls.Add(this.cboNumRecu);
            this.panelCentral.Controls.Add(this.txtFraisID);
            this.panelCentral.Controls.Add(this.label11);
            this.panelCentral.Controls.Add(this.cboFrais);
            this.panelCentral.Controls.Add(this.cboMois);
            this.panelCentral.Controls.Add(this.label10);
            this.panelCentral.Controls.Add(this.dateTimePicker);
            this.panelCentral.Controls.Add(this.label9);
            this.panelCentral.Controls.Add(this.label8);
            this.panelCentral.Controls.Add(this.txtMontant);
            this.panelCentral.Controls.Add(this.label7);
            this.panelCentral.Controls.Add(this.label6);
            this.panelCentral.Controls.Add(this.txtPrenom);
            this.panelCentral.Controls.Add(this.txtPostnom);
            this.panelCentral.Controls.Add(this.txtNom);
            this.panelCentral.Controls.Add(this.cboMatricule);
            this.panelCentral.Controls.Add(this.label12);
            this.panelCentral.Controls.Add(this.label5);
            this.panelCentral.Controls.Add(this.label4);
            this.panelCentral.Controls.Add(this.label3);
            this.panelCentral.Controls.Add(this.label2);
            this.panelCentral.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCentral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panelCentral.Location = new System.Drawing.Point(7, 66);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(761, 212);
            this.panelCentral.TabIndex = 1;
            // 
            // txtClasse
            // 
            this.txtClasse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eleveBindingSource, "CodeClasse", true));
            this.txtClasse.Location = new System.Drawing.Point(229, 64);
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.Size = new System.Drawing.Size(82, 23);
            this.txtClasse.TabIndex = 4;
            // 
            // cboNumRecu
            // 
            this.cboNumRecu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboNumRecu.FormattingEnabled = true;
            this.cboNumRecu.Location = new System.Drawing.Point(229, 111);
            this.cboNumRecu.Name = "cboNumRecu";
            this.cboNumRecu.Size = new System.Drawing.Size(61, 30);
            this.cboNumRecu.TabIndex = 22;
            // 
            // txtFraisID
            // 
            this.txtFraisID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fraiBindingSource, "NumFrais", true));
            this.txtFraisID.Location = new System.Drawing.Point(430, 113);
            this.txtFraisID.Name = "txtFraisID";
            this.txtFraisID.Size = new System.Drawing.Size(57, 23);
            this.txtFraisID.TabIndex = 6;
            // 
            // fraiBindingSource
            // 
            this.fraiBindingSource.DataSource = typeof(MetroUI.Frai);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(364, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Frais ID :";
            // 
            // cboFrais
            // 
            this.cboFrais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fraiBindingSource, "NomFrais", true));
            this.cboFrais.DataSource = this.fraiBindingSource;
            this.cboFrais.DisplayMember = "NomFrais";
            this.cboFrais.FormattingEnabled = true;
            this.cboFrais.Location = new System.Drawing.Point(430, 63);
            this.cboFrais.Name = "cboFrais";
            this.cboFrais.Size = new System.Drawing.Size(307, 25);
            this.cboFrais.TabIndex = 5;
            this.cboFrais.ValueMember = "NomFrais";
            // 
            // cboMois
            // 
            this.cboMois.DataSource = this.moisBindingSource;
            this.cboMois.DisplayMember = "CodeMois";
            this.cboMois.FormattingEnabled = true;
            this.cboMois.Location = new System.Drawing.Point(430, 158);
            this.cboMois.Name = "cboMois";
            this.cboMois.Size = new System.Drawing.Size(43, 25);
            this.cboMois.TabIndex = 8;
            this.cboMois.ValueMember = "CodeMois";
            // 
            // moisBindingSource
            // 
            this.moisBindingSource.DataSource = typeof(MetroUI.Mois);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(381, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Frais :";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(624, 158);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(90, 23);
            this.dateTimePicker.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(574, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mois :";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(624, 113);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(78, 23);
            this.txtMontant.TabIndex = 7;
            this.txtMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(551, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Montant :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Classe :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eleveBindingSource, "Prenom", true));
            this.txtPrenom.Location = new System.Drawing.Point(624, 20);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ReadOnly = true;
            this.txtPrenom.Size = new System.Drawing.Size(113, 23);
            this.txtPrenom.TabIndex = 3;
            // 
            // txtPostnom
            // 
            this.txtPostnom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPostnom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eleveBindingSource, "PostNom", true));
            this.txtPostnom.Location = new System.Drawing.Point(430, 19);
            this.txtPostnom.Name = "txtPostnom";
            this.txtPostnom.ReadOnly = true;
            this.txtPostnom.Size = new System.Drawing.Size(119, 23);
            this.txtPostnom.TabIndex = 2;
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eleveBindingSource, "Nom", true));
            this.txtNom.Location = new System.Drawing.Point(229, 19);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(113, 23);
            this.txtNom.TabIndex = 1;
            // 
            // cboMatricule
            // 
            this.cboMatricule.DataSource = this.eleveBindingSource;
            this.cboMatricule.DisplayMember = "MatriculeEl";
            this.cboMatricule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboMatricule.FormattingEnabled = true;
            this.cboMatricule.Location = new System.Drawing.Point(85, 18);
            this.cboMatricule.Name = "cboMatricule";
            this.cboMatricule.Size = new System.Drawing.Size(92, 25);
            this.cboMatricule.TabIndex = 0;
            this.cboMatricule.ValueMember = "MatriculeEl";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(162, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "N° Reçu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Matricule :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Postnom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom :";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataSource = typeof(MetroUI.Class);
            // 
            // bunifuDragControl
            // 
            this.bunifuDragControl.Fixed = true;
            this.bunifuDragControl.Horizontal = true;
            this.bunifuDragControl.TargetControl = this.panelEntete;
            this.bunifuDragControl.Vertical = true;
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 36;
            this.bunifuElipse.TargetControl = this;
            // 
            // payeBindingSource
            // 
            this.payeBindingSource.DataSource = typeof(MetroUI.Paye);
            // 
            // recuBindingSource
            // 
            this.recuBindingSource.DataSource = typeof(MetroUI.Recu);
            // 
            // frmPayement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 349);
            this.Controls.Add(this.panelDroit);
            this.Controls.Add(this.panelGauche);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmPayement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPayement";
            this.Load += new System.EventHandler(this.frmPayement_Load);
            this.panelDroit.ResumeLayout(false);
            this.panelEntete.ResumeLayout(false);
            this.panelEntete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eleveBindingSource)).EndInit();
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fraiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGauche;
        private System.Windows.Forms.Panel panelDroit;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.ComboBox cboMatricule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtPostnom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboMois;
        private System.Windows.Forms.Panel panelEntete;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox cboTestMatricule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFrais;
        private System.Windows.Forms.Label lblFermer;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl;
        private System.Windows.Forms.TextBox txtFraisID;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private MetroFramework.Controls.MetroTile metroTileEnregistrer;
        private MetroFramework.Controls.MetroTile metroTileAnnuler;
        private MetroFramework.Controls.MetroTile metroTileImprimer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource eleveBindingSource;
        private System.Windows.Forms.BindingSource classBindingSource;
        private System.Windows.Forms.BindingSource fraiBindingSource;
        private System.Windows.Forms.BindingSource moisBindingSource;
        private System.Windows.Forms.BindingSource payeBindingSource;
        private System.Windows.Forms.BindingSource recuBindingSource;
        private System.Windows.Forms.ComboBox cboNumRecu;
        private System.Windows.Forms.TextBox txtClasse;
    }
}