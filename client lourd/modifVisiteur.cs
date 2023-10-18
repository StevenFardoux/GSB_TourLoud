using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassGSB;

namespace client_lourd
{
    public partial class modifVisiteur : Form
    {
        public modifVisiteur(pageAutre page, Visiteur visiteur)
        {
            InitializeComponent();

            txtNom.Text = visiteur.getNom();
            txtPrenom.Text = visiteur.getPrenom();

            btnModif.Click += async (s, e) =>
            {
                if (txtNom.Text.Trim() != "" && txtPrenom.Text.Trim() != "")
                {
                    await passerelle.modifVisiteur(visiteur, txtNom.Text.Trim(), txtPrenom.Text.Trim());
                    page.refreshVisiteur();
                }
            };
        }
    }
}
