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
    public partial class frmEnregistrementEleve : MetroFramework.Forms.MetroForm
    {
        DefenseTimoEntities bd;
        public frmEnregistrementEleve()
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

        }
        public Eleve InfoEleve { get; set; }
        public frmEnregistrementEleve(Eleve el)
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
            cboGenre.Text = " ";
            mtCboCodeClasse.Text = " ";
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            bd = new DefenseTimoEntities();
            Eleve el = new Eleve();
            bd.Eleves.Add(el);
            eleveBindingSource.Add(el);
            eleveBindingSource.MoveLast();

            panel.Enabled = true;
           
            btnEnregistrer.Enabled = true;
            btnAnnuler.Enabled = true;
            txtMatricule.Focus();   
        }

        private async void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMatricule.Text))
             {
                if (!string.IsNullOrEmpty(txtNom.Text))
                {
                    if(!string.IsNullOrEmpty(txtPostNom.Text))
                    {
                        if (!string.IsNullOrEmpty(txtPrenom.Text))
                        {
                            if(!string.IsNullOrEmpty(cboGenre.Text))
                            {
                                if (!string.IsNullOrEmpty(mtDateNaissance.Text))
                                {
                                    if(!string.IsNullOrEmpty(mtCboCodeClasse.Text))
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
                                }
                            }
                        }
                    }
                }
            }//Fin
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
