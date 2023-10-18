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
    public partial class modifMedecin : Form
    {
        public static Medecin medecin;
        public pageAutre pageAutre;
        public modifMedecin(pageAutre pageAutre, Medecin medecin)
        {
            InitializeComponent();
            modifMedecin.medecin = medecin;
            this.pageAutre = pageAutre;
            txtNom.Text = medecin.getNom();
            txtPrenom.Text = medecin.getPrenom();
            txtMail.Text = medecin.getMail();
            txtMdp.Text = medecin.getMotDePasse();
            this.pageAutre = pageAutre;


        }

        private async void btnModif_Click (object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string mail = txtMail.Text;
            string pwd = txtMdp.Text;
            await passerelle.modifMedecin(medecin, nom, prenom, mail, pwd);
            pageAutre.refreshMedecin();
            this.Close();
        }
    }
}
