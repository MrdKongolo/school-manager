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
    public partial class frmListeEleve : MetroFramework.Forms.MetroForm
    {
        DefenseTimoEntities bd;
        public frmListeEleve()
        {
            InitializeComponent();
        }
      

        private void frmListeEleve_Load(object sender, EventArgs e)
        {
            bd = new DefenseTimoEntities();
            bd.Configuration.ProxyCreationEnabled = false;
            bd.Configuration.LazyLoadingEnabled = false;
            eleveBindingSource.DataSource = bd.Eleves.ToList();
            CalculTotal();
        }        
        private void metroGridListeEleves_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Eleve obj = eleveBindingSource.Current as Eleve;
            if (obj != null)
            {
                using (frmAfficheEleve frm = new frmAfficheEleve(obj))
                {
                    frm.ShowDialog();                                       
                }
            }
        } 

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRechercher.Text))
            {
                metroGridListeEleves.DataSource = eleveBindingSource;
            }
            else
            {
                var query = from o in eleveBindingSource.DataSource as List<Eleve>
                            where o.MatriculeEl.StartsWith((txtRechercher.Text).ToUpper()) || o.Nom.Contains((txtRechercher.Text).ToUpper()) || o.PostNom.Contains((txtRechercher.Text).ToUpper()) || o.Prenom.Contains((txtRechercher.Text).ToUpper()) ||
                                        o.CodeClasse == txtRechercher.Text || o.Sexe == (txtRechercher.Text).ToUpper()
                            select o;
                metroGridListeEleves.DataSource = query.ToList();
                CalculTotal();
            }
        }

        private void btnRaffraichir_Click(object sender, EventArgs e)
        {
            txtRechercher.Text = null;
            metroGridListeEleves.Refresh();
            CalculTotal();
        }
        public void CalculTotal()
        {
            int nb = metroGridListeEleves.DisplayedRowCount(true);
            mtLblTotal.Text = String.Format($"{nb}");
        }
    }
}
