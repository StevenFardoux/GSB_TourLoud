using System.Windows.Forms;
using ClassGSB;

namespace client_lourd
{
    public partial class pageAutre : Form
    {
        public pageAutre()
        {
            InitializeComponent();

            //ferme toutes les pages lorsque la croix est cliquer
            this.FormClosing += (s, e) =>
            {
                Application.Exit();
            };
            //met le form en pleine écran
            this.WindowState = FormWindowState.Maximized;

            dgvVisiteur.AutoGenerateColumns = false;

            refreshVisiteur();
            refreshMedecin();


            btnAddVisiteur.Click += (s, e) =>
            {
                if (txtNom.Text.Trim() != "" && txtPrenom.Text.Trim() != "")
                {
                    passerelle.addVisteur(new Visiteur(1, txtNom.Text, txtPrenom.Text));
                    refreshVisiteur();
                }
            };

            btnModifVisiteur.Click += (s, e) =>
            {
                modifVisiteur frm = new modifVisiteur(this, dgvVisiteur.CurrentRow.DataBoundItem as Visiteur);
                frm.Show();
            };

            btnSupprVisiteur.Click += (s, e) =>
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer le visiteur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    passerelle.delVisiteur(dgvVisiteur.CurrentRow.DataBoundItem as Visiteur);
                    refreshVisiteur();
                }
            };


            btnAddMedecin.Click += (s, e) =>
            {
                if (txtNomMed.Text.Trim() != "" && txtPrenomMed.Text.Trim() != "" && txtMail.Text.Trim() != "" && txtMdp.Text.Trim() != "")
                {
                    passerelle.addMedecin(new Medecin(1, txtNomMed.Text.Trim(), txtPrenomMed.Text.Trim(), txtMail.Text.Trim(), txtMdp.Text.Trim(), (txtRpps.Text.Trim() != "") ? txtRpps.Text.Trim() : " ", dtpObtention.Value));
                    refreshMedecin();
                }
            };

            btnModifMedecin.Click += (s, e) =>
            {
                modifMedecin frm = new modifMedecin(this, dgvMedecin.CurrentRow.DataBoundItem as Medecin);
                frm.Show();
            };

            btnDelMedecin.Click += (s, e) =>
            {
                passerelle.delMedecin(dgvMedecin.CurrentRow.DataBoundItem as Medecin);
                refreshMedecin();
            };

        }

        public async void refreshVisiteur()
        {
            dgvVisiteur.DataSource = null;
            dgvVisiteur.DataSource = await passerelle.getLesVisiteurs();
        }

        public async void refreshMedecin()
        {
            dgvMedecin.DataSource = null;
            dgvMedecin.DataSource = await passerelle.getLesMedecins();
        }
    }
}
