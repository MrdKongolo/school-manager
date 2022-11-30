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
    public partial class frmFrais : MetroFramework.Forms.MetroForm
    {
        DefenseTimoEntities bd;
        public frmFrais()
        {
            InitializeComponent();
        }

        private void frmFrais_Load(object sender, EventArgs e)
        {
            bd = new DefenseTimoEntities();
            bd.Configuration.ProxyCreationEnabled = false;
            bd.Configuration.LazyLoadingEnabled = false;
            fraiBindingSource.DataSource = bd.Frais.ToList();
            gpbFrais.Enabled = false;          
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            bd = new DefenseTimoEntities();
            Frai fr = new Frai();
            bd.Frais.Add(fr);
            fraiBindingSource.Add(fr);
            fraiBindingSource.MoveLast();
            gpbFrais.Enabled = true;
            txtNumFrais.Focus();
        }

        private async void btnEnreg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumFrais.Text) || string.IsNullOrEmpty(txtNomFrais.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Veuillez remplir les champs réquis !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                fraiBindingSource.EndEdit();
                await bd.SaveChangesAsync();
                MetroFramework.MetroMessageBox.Show(this, "Bien enregistré !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumFrais.Text = string.Empty;
                txtNomFrais.Text = string.Empty;
                metroGridFrais.Refresh();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
