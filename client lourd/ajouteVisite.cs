using ClassGSB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client_lourd
{
    public partial class ajouteVisite : Form
    {
        public ajouteVisite(pageVisiteurs pageVisiteurs, List<Visiteur> lesVisiteurs, List<Medecin> lesMedecins)
        {
            InitializeComponent();
            
            //passerelle.setListMedecin();
            cmbMedecin.DataSource = lesMedecins;

            //passerelle.setListVisiteur();
            cmbVisiteur.DataSource = lesVisiteurs;

            btnAjouter.Click += async (s, e) =>
            {
                await passerelle.addVisite(new Visite((Medecin)cmbMedecin.SelectedItem,
                    (Visiteur)cmbVisiteur.SelectedItem,
                    txtAdresse.Text,
                    dateVisite.Value
                ));
                pageVisiteurs.refresh();
                this.Close();
            };
        }

        
    }
}
