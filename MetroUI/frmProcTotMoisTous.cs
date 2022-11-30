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
    public partial class frmProcTotMoisTous : MetroFramework.Forms.MetroForm
    {
        public frmProcTotMoisTous()
        {
            InitializeComponent();
        }

        private void frmProcTotMoisTous_Load(object sender, EventArgs e)
        {
            using (DefenseTimoEntities db = new DefenseTimoEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.LazyLoadingEnabled = false;
                viewTotalMoisParEleveTouBindingSource.DataSource = db.ViewTotalMoisParEleveTous.ToList();
            }
        }
    }
}
