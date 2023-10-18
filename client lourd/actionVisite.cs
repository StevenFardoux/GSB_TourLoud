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
    public partial class actionVisite : Form
    {
        //public Form3(Visite visite)
        public actionVisite(pageVisiteurs pageVisiteurs, Visite visite)
        {
            InitializeComponent();

            btnModifier.Click += async (s, e) =>
            {
                modifVisite modifVisite = new modifVisite(this, pageVisiteurs, visite , await passerelle.getLesVisiteurs(), await passerelle.getLesMedecins());
                modifVisite.Show();
            };

            btnDelete.Click += async (s, e) =>
            {
                await passerelle.delVisite(visite);
                pageVisiteurs.refresh();
                this.Close();
            };
        }
    }
}
