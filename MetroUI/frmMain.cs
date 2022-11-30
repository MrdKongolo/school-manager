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
    public partial class frmMain : Form
    {
        DefenseTimoEntities bd;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEnregistrementEleve_Click(object sender, EventArgs e)
        {
            frmEnregistrementEleve enregistrement = new frmEnregistrementEleve();
            enregistrement.ShowDialog();
        }

        private void btnPayementFrais_Click(object sender, EventArgs e)
        {
            frmPayement payement = new frmPayement();
            payement.Show();
        }

        private void btnFrais_Click(object sender, EventArgs e)
        {
            frmFrais frais = new frmFrais();
            frais.Show();
        }

        private void btnClasse_Click(object sender, EventArgs e)
        {
            frmClasse classe = new frmClasse();
            classe.Show();
        }

        private void btnListeEleve_Click(object sender, EventArgs e)
        {
            frmListeEleve listeEleve = new frmListeEleve();
            listeEleve.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            bd = new DefenseTimoEntities();
            bd.Configuration.ProxyCreationEnabled = false;
            bd.Configuration.LazyLoadingEnabled = false;
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            using (DefenseTimoEntities bd = new DefenseTimoEntities())
            {
                if (string.IsNullOrEmpty(txtMdP.Text) || string.IsNullOrEmpty(txtUtilisateur.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Veillez entrer vos identifiants pour vous connecter.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                try
                {
                    using (DefenseTimoEntities db = new DefenseTimoEntities())
                    {
                        var req = (from u in db.Utilisateurs
                                   where u.Identifiant == txtUtilisateur.Text && u.Mdp == txtMdP.Text
                                   select u).SingleOrDefault();
                        if (req != null)
                        {
                            panelDroit.Hide();
                            panelVrai.Enabled = true;
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Veillez entrer vos identifiants pour vous connecter.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Identifiant ou mot de passe incorrect.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVoirPayement_Click(object sender, EventArgs e)
        {
            new frmProcLignePayement().ShowDialog();
        }

        private void btnTotalParEleve_Click(object sender, EventArgs e)
        {
            new frmProcTotMoisTous().ShowDialog();
        }
    }
}
