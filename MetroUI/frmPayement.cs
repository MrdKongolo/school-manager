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
    public partial class frmPayement : Form
    {
        DefenseTimoEntities bd;
        public frmPayement()
        {
            InitializeComponent();
        }
        private void lblFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPayement_Load(object sender, EventArgs e)
        {
            bd = new DefenseTimoEntities();
            bd.Configuration.ProxyCreationEnabled = false;
            bd.Configuration.LazyLoadingEnabled = false;

            eleveBindingSource.DataSource = bd.Eleves.ToList();
            classBindingSource.DataSource = bd.Classes.ToList();
            fraiBindingSource.DataSource = bd.Frais.ToList();
            moisBindingSource.DataSource = bd.Mois.ToList();
            payeBindingSource.DataSource = bd.Payes.ToList();
            
            cboNumRecu.DataSource = bd.ProcNumeroRecu().ToList();
            panelCentral.Enabled = false;
            dateTimePicker.Text = (DateTime.Today).ToShortDateString();
            Nettoyer();
            metroTileImprimer.Enabled = false;
        }

        private void metroTileImprimer_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmImprimerRecu recu = new frmImprimerRecu(string.Format("{0:00} FC", txtMontant.Text), string.Format($"{txtClasse.Text}"), string.Format($"{cboNumRecu.Text}"), string.Format($"{txtNom.Text}"), string.Format($"{txtPostnom.Text}"), string.Format($"{txtPrenom.Text}"), string.Format($"{cboFrais.Text}"), string.Format($"{dateTimePicker.Text}")))
                {
                    recu.ShowDialog();
                }
            }
            catch (Exception er)
            {
                MetroFramework.MetroMessageBox.Show(this, er.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            bd = new DefenseTimoEntities();
            try
            {
                var query = bd.Eleves.Where(el => el.MatriculeEl == cboTestMatricule.Text).Single();
                panelCentral.Enabled = true;
                cboMatricule.Text = cboTestMatricule.Text;                                              
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this,"Ce matricule ne figure pas dans notre base de données.","Erreur ",MessageBoxButtons.OK, MessageBoxIcon.Error);
                Nettoyer();
                panelCentral.Enabled = false;
            }
        }
        public void Nettoyer()
        {
            cboMatricule.Text = string.Empty;
            txtClasse.Text = string.Empty;
            cboFrais.Text = string.Empty;
            cboMois.Text = string.Empty;
            cboTestMatricule.Text = string.Empty;
            txtNom.Text = null;
            txtPostnom.Text = null;
            txtPrenom.Text = null;
            txtFraisID.Text = null;
            txtMontant.Text = null;
        }

        private async void metroTileEnregistrer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFraisID.Text))
            {
                if(!string.IsNullOrEmpty(cboMois.Text))
                {
                    if (!string.IsNullOrEmpty(txtMontant.Text))
                    {
                        if (!string.IsNullOrEmpty(cboFrais.Text))
                        {
                            bd = new DefenseTimoEntities();
                            //Création de l'objet Paye
                            Paye p = new Paye();
                            bd.Payes.Add(p);
                            payeBindingSource.Add(p);
                            payeBindingSource.MoveLast();
                            //
                            try
                            {
                                p.MatriculeEl = cboMatricule.Text;
                                p.NumFrais = txtFraisID.Text;
                                p.Montant = Decimal.Parse(txtMontant.Text);
                                p.DatePaye = DateTime.Parse(dateTimePicker.Text);
                                p.CodeMois = cboMois.Text;

                                //Enregistrement de la ligne de payement
                                payeBindingSource.EndEdit();
                                await bd.SaveChangesAsync();
                            }
                            catch (Exception er)
                            {
                                MetroFramework.MetroMessageBox.Show(this, er.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            //Création de l'objet Reçu
                            Recu r = new Recu();
                            bd.Recus.Add(r);
                            recuBindingSource.Add(r);
                            recuBindingSource.MoveLast();
                            try
                            {
                                //Enregistrement d'un reçu
                                r.Motif = cboFrais.Text;
                                r.MatriculeEl = cboMatricule.Text;
                                r.DateRecu = DateTime.Now;

                                recuBindingSource.EndEdit();
                                await bd.SaveChangesAsync();
                                MetroFramework.MetroMessageBox.Show(this, "Données bien enregistrées ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                metroTileImprimer.Enabled = true;
                            }
                            catch (Exception er)
                            {
                                MetroFramework.MetroMessageBox.Show(this, er.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }                            
                        }
                    }
                }
            }
            cboNumRecu.Refresh();
        }

        private void metroTileAnnuler_Click(object sender, EventArgs e)
        {
            payeBindingSource.ResetBindings(false);
            Nettoyer();
            panelCentral.Enabled = false;            
        }
        
    }
}
