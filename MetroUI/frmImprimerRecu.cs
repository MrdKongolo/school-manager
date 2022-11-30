using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace MetroUI
{
    public partial class frmImprimerRecu : MetroFramework.Forms.MetroForm
    {
        //Déclaration des attributs de notre reçu
        string _montant, _classe, _numRecu, _nom, _postNom, _prenom, _motif, _date;
        
        //Constructeur avec tous les paramètres
        public frmImprimerRecu(string montant, string classe, string numRecu, string nom, string postNom, string prenom, string motif, string date)
        {
            InitializeComponent();
            _montant = montant;
            _classe = classe;
            _numRecu = numRecu;
            _nom = nom;
            _postNom = postNom;
            _prenom = prenom;
            _motif = motif;
            _date = date;
        }

        private void frmImprimerRecu_Load(object sender, EventArgs e)
        {
            ReportParameter[] param = new ReportParameter[]
            {
                new ReportParameter("pMontant",_montant),
                new ReportParameter("pClasse", _classe),
                new ReportParameter("pNumRecu",_numRecu),
                new ReportParameter("pNom",_nom),
                new ReportParameter("pPostnom",_postNom),
                new ReportParameter("pPrenom",_prenom),
                new ReportParameter("pMotif",_motif),
                new ReportParameter("pDate",_date),
            };
            this.reportViewerRecu.LocalReport.SetParameters(param);
            this.reportViewerRecu.RefreshReport();
        }
    }
}
