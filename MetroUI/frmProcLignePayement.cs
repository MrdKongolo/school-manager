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
    public partial class frmProcLignePayement : MetroFramework.Forms.MetroForm
    {
        public frmProcLignePayement()
        {
            InitializeComponent();
        }

        private void frmProcLignePayement_Load(object sender, EventArgs e)
        {
            using(DefenseTimoEntities db = new DefenseTimoEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.LazyLoadingEnabled = false;
                viewLignePayementBindingSource.DataSource = db.ViewLignePayements.ToList();
            }
            CalculTotal();
        }
        public void CalculTotal()
        {
            int nb = metroGrid.DisplayedRowCount(true);
            mtLblTotal.Text = String.Format($"{nb}");
        }

        private void metroTileFiltrer_Click(object sender, EventArgs e)
        {
            if (btnRadioPayeAujourd.Checked)
            {
                var query = from o in viewLignePayementBindingSource.DataSource as List<ViewLignePayement>
                            where o.DatePaye == DateTime.Today
                            select o;
                metroGrid.DataSource = query.ToList();
                CalculTotal();
            }
            if (btnRadioFiltreEntre.Checked)
            {
                var query = from o in viewLignePayementBindingSource.DataSource as List<ViewLignePayement>
                            where o.DatePaye >= DateTime.Parse(dtDebut.Text) && o.DatePaye <= DateTime.Parse(dtFin.Text)
                            select o;
                metroGrid.DataSource = query.ToList();
                CalculTotal();
            }
            if (btnRadioFiltreAyantPayer.Checked)
            {
                var query = from o in viewLignePayementBindingSource.DataSource as List<ViewLignePayement>
                            where o.DatePaye > DateTime.Parse(dtApres.Text)
                            select o;
                metroGrid.DataSource = query.ToList();
                CalculTotal();
            }

        }

        private void metroTileRaffraichir_Click(object sender, EventArgs e)
        {
            using (DefenseTimoEntities db = new DefenseTimoEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.LazyLoadingEnabled = false;
                viewLignePayementBindingSource.DataSource = db.ViewLignePayements.ToList();
            }
            CalculTotal();
        }
    }
}
