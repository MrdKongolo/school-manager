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
    public partial class frmClasse : MetroFramework.Forms.MetroForm
    {
        DefenseTimoEntities bd;
        public frmClasse()
        {
            InitializeComponent();
        }

        private void frmClasse_Load(object sender, EventArgs e)
        {
            bd = new DefenseTimoEntities();
            bd.Configuration.ProxyCreationEnabled = false;
            bd.Configuration.LazyLoadingEnabled = false;
            classBindingSource.DataSource = bd.Classes.ToList();
            panel.Enabled = false;
            Nettoyer();
        }

        private void Nettoyer()
        {
            txtCodeClasse.Text = null;
            txtClasse.Text = null;
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            bd = new DefenseTimoEntities();
            //Création de l'objet Classe
            Class cl = new Class();
            bd.Classes.Add(cl);
            classBindingSource.Add(cl);
            classBindingSource.MoveLast();
            panel.Enabled = true;
            txtCodeClasse.Focus();
        }

        private async void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodeClasse.Text) || !string.IsNullOrEmpty(txtClasse.Text))
            {
                try
                {
                    classBindingSource.EndEdit();
                    await bd.SaveChangesAsync();
                    MetroFramework.MetroMessageBox.Show(this, "Bien enregistré !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Nettoyer();
                    panel.Enabled = false;
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erreur lors de l'enregistrement ... !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
                      
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Voulez-vous vraiment supprimer cet élément ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // CODE A COMPLETER
                //bd.Classes.Remove(classBindingSource.Current as Class);
                classBindingSource.RemoveCurrent();
            }           
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtCodeClasse.Focus();
        }
    }
}
