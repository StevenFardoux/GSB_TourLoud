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
    public partial class pageVisiteurs : Form
    {
        public pageVisiteurs()
        {
            InitializeComponent();

            this.FormClosing += (s, e) =>
            {
                Application.Exit();
            };

            btnAdd.Click += async (s, e) =>
            {
                ajouteVisite form4 = new ajouteVisite(this, await passerelle.getLesVisiteurs(), await passerelle.getLesMedecins());
                form4.Show();
            };

            editButton.Click += (s, e) =>
            {
                actionVisite frm = new actionVisite(this, listDeVisite.CurrentRow.DataBoundItem as Visite);
                frm.Show();
            };

            listDeVisite.AutoGenerateColumns = false;
            this.refresh();
        }

        public async void refresh()
        {
            listDeVisite.DataSource = null;
            listDeVisite.DataSource = await passerelle.getLesVisites();

            // create a thread in lambda
            List<Visite> lesVisites = listDeVisite.DataSource as List<Visite>;
            Visiteur visiteurDuMois = null;

            foreach (Visite visite in lesVisites)
            {
                Visiteur visiteur = visite.getVisiteur();

                if (visiteurDuMois == null || lesVisites.Where(v => v.getVisiteur() == visiteur).Count() > lesVisites.Where(v => v.getVisiteur() == visiteurDuMois).Count())
                {
                    visiteurDuMois = visiteur;
                    lblVisiteurDuMois.Text = visiteurDuMois.getNom() + " " + visiteurDuMois.getPrenom();
                }
            }
            //Visiteur visiteur = lesVisites.Where(v => v.getVisiteur().getId() == 5).First().getVisiteur();

            lblVisiteTotal.Text = lesVisites.Count.ToString();
            lblVisite.Text = lesVisites.Where(v => v.getVisiteur().getId() == 5).Count().ToString();
            lblVisiteurDuMois.Text = visiteurDuMois.getNom() + " " + visiteurDuMois.getPrenom();
        }
    }
}
