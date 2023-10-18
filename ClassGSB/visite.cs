using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGSB
{
    public class Visite
    {
        private int id;
        private Medecin medecin;
        private Visiteur visiteur;
        private string adresse;
        private DateTime dateVisite;

        public int Id { get => id; set => id = value; }
        public Medecin Medecin { get => medecin; set => medecin = value; }
        public Visiteur Visiteur { get => visiteur; set => visiteur = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public DateTime DateVisite { get => dateVisite; set => dateVisite = value; }

        /// <summary>
        /// Constructeur de la classe Visite
        /// </summary>
        public Visite()
        {
        }

        /// <summary>
        /// Constructeur de la classe Visite
        /// </summary>
        /// <param name="medecin">Le médecin</param>
        /// <param name="visiteur">Le visiteur</param>
        /// <param name="adresse">L'adresse</param>
        /// <param name="dateVisite">La date de la visite</param>
        public Visite(Medecin medecin, Visiteur visiteur, string adresse, DateTime dateVisite)
        {
            this.medecin = medecin;
            this.visiteur = visiteur;
            this.adresse = adresse;
            this.dateVisite = dateVisite;
        }

        /// <summary>
        /// Constructeur de la classe Visite
        /// </summary>
        /// <param name="id">L'identifiant de la visite</param>
        /// <param name="medecin">Le médecin</param>
        /// <param name="visiteur">Le visiteur</param>
        /// <param name="adresse">L'adresse</param>
        /// <param name="dateVisite">La date de la visite</param>
        public Visite(int id, Medecin medecin, Visiteur visiteur, string adresse, DateTime dateVisite) : this(medecin, visiteur, adresse, dateVisite)
        {
            this.id = id;
        }

        /// <summary>
        /// Accesseur de l'identifiant de la visite
        /// </summary>
        /// <returns>L'identifiant de la visite</returns>
        public int getId()
        {
            return this.id;
        }

        /// <summary>
        /// Accesseur du médecin
        /// </summary>
        /// <returns>Le médecin</returns>
        public Medecin getMedecin()
        {
            return this.medecin;
        }

        /// <summary>
        /// Accesseur du visiteur
        /// </summary>
        /// <returns>Le visiteur</returns>
        public Visiteur getVisiteur()
        {
            return this.visiteur;
        }

        /// <summary>
        /// Accesseur de l'adresse
        /// </summary>
        /// <returns>L'adresse</returns>
        public string getAdresse()
        {
            return this.adresse;
        }

        /// <summary>
        /// Accesseur de la date de la visite
        /// </summary>
        /// <returns>La date de la visite</returns>
        public DateTime getDateVisite()
        {
            return this.dateVisite;
        }

        /// <summary>
        /// Mutateur de l'identifiant de la visite
        /// </summary>
        /// <param name="id">L'identifiant de la visite</param>
        public void setId(int id)
        {
            this.id = id;
        }

        /// <summary>
        /// Mutateur du médecin
        /// </summary>
        /// <param name="medecin">Le médecin</param>
        public void setMedecin(Medecin medecin)
        {
            this.medecin = medecin;
        }

        /// <summary>
        /// Mutateur du visiteur
        /// </summary>
        /// <param name="visiteur">Le visiteur</param>
        public void setVisiteur(Visiteur visiteur)
        {
            this.visiteur = visiteur;
        }

        /// <summary>
        /// Mutateur de l'adresse
        /// </summary>
        /// <param name="adresse">L'adresse</param>
        public void setAdresse(string adresse)
        {
            this.adresse = adresse;
        }

        /// <summary>
        /// Mutateur de la date de la visite
        /// </summary>
        /// <param name="dateVisite">La date de la visite</param>
        public void setDateVisite(DateTime dateVisite)
        {
            this.dateVisite = dateVisite;
        }

        public override string ToString()
        {
            return "Visite [id=" + id + ", medecin=" + medecin + ", visiteur=" + visiteur + ", adresse=" + adresse + ", dateVisite=" + dateVisite + "]";
        }
    }
}
