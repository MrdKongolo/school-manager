using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroUI
{
    public partial class frmAfficheEleve : MetroFramework.Forms.MetroForm
    {
        DefenseTimoEntities bd;
        public frmAfficheEleve()
        {
            InitializeComponent();
        }
       
        private void frmEnregistrementEleve_Load(object sender, EventArgs e)
        {
            bd = new DefenseTimoEntities();
            bd.Configuration.ProxyCreationEnabled = false;
            bd.Configuration.LazyLoadingEnabled = false;

            Nettoyer();
            eleveBindingSource.DataSource = bd.Eleves.ToList();
            classBindingSource.DataSource = bd.Classes.ToList();
            panel.Enabled = false;
            btnEnregistrer.Enabled = false;
            btnAnnuler.Enabled = false;

            //Chargement des informations pour un élève lorsque l'on double dans la liste
            try
            {
                txtMatricule.Text = InfoEleve.MatriculeEl;
                txtNom.Text = InfoEleve.Nom;
                txtPostNom.Text = InfoEleve.PostNom;
                txtPrenom.Text = InfoEleve.Prenom;
                cboGenre.Text = InfoEleve.Sexe;
                mtCboCodeClasse.Text = InfoEleve.CodeClasse;
                mtDateNaissance.Text = string.Format($"{InfoEleve.DateNaissance}");
            }
            catch (Exception er)
            {
                MetroFramework.MetroMessageBox.Show(this, er.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            } 
        }
        public Eleve InfoEleve { get; set; }
        public frmAfficheEleve(Eleve el)
        {
            InitializeComponent();
            InfoEleve = el;
        }
        private void Nettoyer()
        {
            txtMatricule.Text = null;
            txtNom.Text = null;
            txtPostNom.Text = null;
            txtPrenom.Text = null;
            cboGenre.Text = string.Empty;
            mtCboCodeClasse.Text = string.Empty;        
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            bd = new DefenseTimoEntities();
            Eleve el = new Eleve();
            bd.Eleves.Add(el);
            eleveBindingSource.Add(el);
            eleveBindingSource.MoveLast();
            Nettoyer();

            panel.Enabled = true;
           
            btnEnregistrer.Enabled = true;
            btnAnnuler.Enabled = true;
            txtMatricule.Focus();   
        }

        private async void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMatricule.Text)&& !string.IsNullOrEmpty(txtNom.Text)&& !string.IsNullOrEmpty(txtPostNom.Text) &&
                !string.IsNullOrEmpty(txtPrenom.Text) && !string.IsNullOrEmpty(cboGenre.Text) && !string.IsNullOrEmpty(mtDateNaissance.Text) && !string.IsNullOrEmpty(mtCboCodeClasse.Text))
            {
                try
                {
                    eleveBindingSource.EndEdit();
                    await bd.SaveChangesAsync();

                    MetroFramework.MetroMessageBox.Show(this, "Bien enregistré !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel.Enabled = false;
                    btnEnregistrer.Enabled = false;
                    Nettoyer();
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Veuillez remplir tous les champs !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            btnEnregistrer.Enabled = false;
            btnAnnuler.Enabled = false;
            classBindingSource.ResetBindings(false);
        }

        private void linkLabelListeEleve_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using(frmListeEleve liste = new frmListeEleve())
            {
                liste.ShowDialog();
            }
        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtMatricule.Focus();
            btnAnnuler.Enabled = true;
            btnEnregistrer.Enabled = true;
        }
    }
}
