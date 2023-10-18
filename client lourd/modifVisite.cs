using ClassGSB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client_lourd
{
    public partial class modifVisite : Form
    {
        public modifVisite(actionVisite actionVisite, pageVisiteurs pageVisiteurs, Visite visite, List<Visiteur> lesVisiteurs, List<Medecin> lesMedecins)
        {
            InitializeComponent();
            cmbMedecin.DataSource = lesMedecins;
            cmbMedecin.SelectedItem = visite.Medecin;

            cmbVisiteur.DataSource = lesVisiteurs;
            cmbVisiteur.SelectedItem = visite.Visiteur;

            txtAdresse.Text = visite.Adresse;
            dateVisite.Value = visite.DateVisite;

            btnModifier.Click += async (s, e) =>
            {
                visite.setMedecin((Medecin)cmbMedecin.SelectedItem);
                visite.setVisiteur((Visiteur)cmbVisiteur.SelectedItem);
                visite.setAdresse(txtAdresse.Text);
                visite.setDateVisite(dateVisite.Value);
                await passerelle.modVisite(visite);
                pageVisiteurs.refresh();
                this.Close();
                actionVisite.Close();
            };
        }
    }
}
