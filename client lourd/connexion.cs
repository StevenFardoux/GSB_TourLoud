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
    public partial class connexion : Form
    {
        public connexion()
        {
            InitializeComponent();

            btnConnect.Click += (s, e) =>
            {
                //vérif info de connexion avant de lancer la page suivante.
            };
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            await passerelle.setListVisiteur();
            await passerelle.setListMedecin();
            pageVisiteurs frm2 = new pageVisiteurs();
            frm2.Show();
            this.Hide();
        }

        private void btnConnectAdmin_Click(object sender, EventArgs e)
        {
            pageAutre frm3 = new pageAutre();
            frm3.Show();
            this.Hide();
        }
    }
}
