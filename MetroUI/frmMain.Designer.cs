namespace MetroUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelEntete = new System.Windows.Forms.Panel();
            this.panelGauche = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.btnEnregistrementEleve = new System.Windows.Forms.Button();
            this.btnPayementFrais = new System.Windows.Forms.Button();
            this.btnListeEleve = new System.Windows.Forms.Button();
            this.btnFrais = new System.Windows.Forms.Button();
            this.btnClasse = new System.Windows.Forms.Button();
            this.panelVrai = new System.Windows.Forms.Panel();
            this.panelDroit = new System.Windows.Forms.Panel();
            this.gbIdentifiezVous = new System.Windows.Forms.GroupBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.txtUtilisateur = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMdP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnTotalParEleve = new System.Windows.Forms.Button();
            this.btnVoirPayement = new System.Windows.Forms.Button();
            this.panelVrai.SuspendLayout();
            this.panelDroit.SuspendLayout();
            this.gbIdentifiezVous.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEntete
            // 
            this.panelEntete.BackColor = System.Drawing.Color.Azure;
            this.panelEntete.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEntete.Location = new System.Drawing.Point(0, 0);
            this.panelEntete.Name = "panelEntete";
            this.panelEntete.Size = new System.Drawing.Size(1178, 63);
            this.panelEntete.TabIndex = 0;
            // 
            // panelGauche
            // 
            this.panelGauche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panelGauche.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGauche.Location = new System.Drawing.Point(0, 63);
            this.panelGauche.Name = "panelGauche";
            this.panelGauche.Size = new System.Drawing.Size(138, 514);
            this.panelGauche.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(138, 555);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1040, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // btnEnregistrementEleve
            // 
            this.btnEnregistrementEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnEnregistrementEleve.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrementEleve.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnregistrementEleve.Location = new System.Drawing.Point(531, 261);
            this.btnEnregistrementEleve.Name = "btnEnregistrementEleve";
            this.btnEnregistrementEleve.Size = new System.Drawing.Size(248, 78);
            this.btnEnregistrementEleve.TabIndex = 4;
            this.btnEnregistrementEleve.Text = "Enregistrement élève";
            this.btnEnregistrementEleve.UseVisualStyleBackColor = false;
            this.btnEnregistrementEleve.Click += new System.EventHandler(this.btnEnregistrementEleve_Click);
            // 
            // btnPayementFrais
            // 
            this.btnPayementFrais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnPayementFrais.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayementFrais.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPayementFrais.Location = new System.Drawing.Point(797, 128);
            this.btnPayementFrais.Name = "btnPayementFrais";
            this.btnPayementFrais.Size = new System.Drawing.Size(217, 78);
            this.btnPayementFrais.TabIndex = 3;
            this.btnPayementFrais.Text = "Payement frais";
            this.btnPayementFrais.UseVisualStyleBackColor = false;
            this.btnPayementFrais.Click += new System.EventHandler(this.btnPayementFrais_Click);
            // 
            // btnListeEleve
            // 
            this.btnListeEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnListeEleve.FlatAppearance.BorderSize = 0;
            this.btnListeEleve.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeEleve.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListeEleve.Location = new System.Drawing.Point(531, 128);
            this.btnListeEleve.Name = "btnListeEleve";
            this.btnListeEleve.Size = new System.Drawing.Size(248, 78);
            this.btnListeEleve.TabIndex = 2;
            this.btnListeEleve.Text = "Liste des élèves";
            this.btnListeEleve.UseVisualStyleBackColor = false;
            this.btnListeEleve.Click += new System.EventHandler(this.btnListeEleve_Click);
            // 
            // btnFrais
            // 
            this.btnFrais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnFrais.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrais.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFrais.Location = new System.Drawing.Point(243, 128);
            this.btnFrais.Name = "btnFrais";
            this.btnFrais.Size = new System.Drawing.Size(133, 78);
            this.btnFrais.TabIndex = 0;
            this.btnFrais.Text = "Frais";
            this.btnFrais.UseVisualStyleBackColor = false;
            this.btnFrais.Click += new System.EventHandler(this.btnFrais_Click);
            // 
            // btnClasse
            // 
            this.btnClasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnClasse.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClasse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClasse.Location = new System.Drawing.Point(396, 128);
            this.btnClasse.Name = "btnClasse";
            this.btnClasse.Size = new System.Drawing.Size(104, 78);
            this.btnClasse.TabIndex = 1;
            this.btnClasse.Text = "Classe";
            this.btnClasse.UseVisualStyleBackColor = false;
            this.btnClasse.Click += new System.EventHandler(this.btnClasse_Click);
            // 
            // panelVrai
            // 
            this.panelVrai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelVrai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVrai.Controls.Add(this.panelDroit);
            this.panelVrai.Controls.Add(this.btnTotalParEleve);
            this.panelVrai.Controls.Add(this.btnVoirPayement);
            this.panelVrai.Controls.Add(this.btnFrais);
            this.panelVrai.Controls.Add(this.btnListeEleve);
            this.panelVrai.Controls.Add(this.btnPayementFrais);
            this.panelVrai.Controls.Add(this.btnEnregistrementEleve);
            this.panelVrai.Controls.Add(this.btnClasse);
            this.panelVrai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVrai.Location = new System.Drawing.Point(0, 0);
            this.panelVrai.Name = "panelVrai";
            this.panelVrai.Size = new System.Drawing.Size(1178, 577);
            this.panelVrai.TabIndex = 6;
            // 
            // panelDroit
            // 
            this.panelDroit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelDroit.Controls.Add(this.gbIdentifiezVous);
            this.panelDroit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDroit.Location = new System.Drawing.Point(0, 0);
            this.panelDroit.Name = "panelDroit";
            this.panelDroit.Size = new System.Drawing.Size(1176, 575);
            this.panelDroit.TabIndex = 5;
            // 
            // gbIdentifiezVous
            // 
            this.gbIdentifiezVous.Controls.Add(this.btnConnexion);
            this.gbIdentifiezVous.Controls.Add(this.txtUtilisateur);
            this.gbIdentifiezVous.Controls.Add(this.txtMdP);
            this.gbIdentifiezVous.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIdentifiezVous.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.gbIdentifiezVous.Location = new System.Drawing.Point(382, 147);
            this.gbIdentifiezVous.Name = "gbIdentifiezVous";
            this.gbIdentifiezVous.Size = new System.Drawing.Size(316, 192);
            this.gbIdentifiezVous.TabIndex = 1;
            this.gbIdentifiezVous.TabStop = false;
            this.gbIdentifiezVous.Text = "Identifiez-vous ici!";
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnexion.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnConnexion.Location = new System.Drawing.Point(114, 114);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(88, 39);
            this.btnConnexion.TabIndex = 2;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // txtUtilisateur
            // 
            this.txtUtilisateur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUtilisateur.Depth = 0;
            this.txtUtilisateur.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilisateur.Hint = "Utilisateur";
            this.txtUtilisateur.Location = new System.Drawing.Point(31, 35);
            this.txtUtilisateur.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUtilisateur.Name = "txtUtilisateur";
            this.txtUtilisateur.PasswordChar = '\0';
            this.txtUtilisateur.SelectedText = "";
            this.txtUtilisateur.SelectionLength = 0;
            this.txtUtilisateur.SelectionStart = 0;
            this.txtUtilisateur.Size = new System.Drawing.Size(177, 23);
            this.txtUtilisateur.TabIndex = 0;
            this.txtUtilisateur.UseSystemPasswordChar = false;
            // 
            // txtMdP
            // 
            this.txtMdP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMdP.Depth = 0;
            this.txtMdP.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMdP.Hint = "Mot de passe";
            this.txtMdP.Location = new System.Drawing.Point(31, 73);
            this.txtMdP.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMdP.Name = "txtMdP";
            this.txtMdP.PasswordChar = '*';
            this.txtMdP.SelectedText = "";
            this.txtMdP.SelectionLength = 0;
            this.txtMdP.SelectionStart = 0;
            this.txtMdP.Size = new System.Drawing.Size(177, 23);
            this.txtMdP.TabIndex = 1;
            this.txtMdP.UseSystemPasswordChar = false;
            // 
            // btnTotalParEleve
            // 
            this.btnTotalParEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnTotalParEleve.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalParEleve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTotalParEleve.Location = new System.Drawing.Point(797, 261);
            this.btnTotalParEleve.Name = "btnTotalParEleve";
            this.btnTotalParEleve.Size = new System.Drawing.Size(227, 75);
            this.btnTotalParEleve.TabIndex = 1;
            this.btnTotalParEleve.Text = "Total par élève";
            this.btnTotalParEleve.UseVisualStyleBackColor = false;
            this.btnTotalParEleve.Click += new System.EventHandler(this.btnTotalParEleve_Click);
            // 
            // btnVoirPayement
            // 
            this.btnVoirPayement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.btnVoirPayement.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoirPayement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoirPayement.Location = new System.Drawing.Point(243, 261);
            this.btnVoirPayement.Name = "btnVoirPayement";
            this.btnVoirPayement.Size = new System.Drawing.Size(257, 75);
            this.btnVoirPayement.TabIndex = 0;
            this.btnVoirPayement.Text = "Voir tous les payements";
            this.btnVoirPayement.UseVisualStyleBackColor = false;
            this.btnVoirPayement.Click += new System.EventHandler(this.btnVoirPayement_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 577);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panelGauche);
            this.Controls.Add(this.panelEntete);
            this.Controls.Add(this.panelVrai);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(613, 369);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERCEPTION FRAIS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelVrai.ResumeLayout(false);
            this.panelDroit.ResumeLayout(false);
            this.gbIdentifiezVous.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEntete;
        private System.Windows.Forms.Panel panelGauche;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Button btnEnregistrementEleve;
        private System.Windows.Forms.Button btnPayementFrais;
        private System.Windows.Forms.Button btnListeEleve;
        private System.Windows.Forms.Button btnFrais;
        private System.Windows.Forms.Button btnClasse;
        private System.Windows.Forms.Panel panelVrai;
        private System.Windows.Forms.Panel panelDroit;
        private System.Windows.Forms.GroupBox gbIdentifiezVous;
        private System.Windows.Forms.Button btnConnexion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUtilisateur;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMdP;
        private System.Windows.Forms.Button btnTotalParEleve;
        private System.Windows.Forms.Button btnVoirPayement;
    }
}