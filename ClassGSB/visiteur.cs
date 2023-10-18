using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGSB
{
    public class Visiteur : Personne
    {
        private int id;
        private List<Visite> listVisite = new List<Visite>();

        public int Id { get => id; set => id = value; }

        /// <summary>
        /// Constructeur de la classe Visite.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        public Visiteur(int id, string nom, string prenom) : base(nom, prenom)
        {
            this.id = id;
        }

        /// <summary>
        /// Constructeur de la classe Visite.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="listVisite"></param>
        public Visiteur(int id, string nom, string prenom, List<Visite> listVisite) : base(nom, prenom)
        {
            this.id = id;
            this.listVisite = listVisite;
        }

        /// <summary>
        /// Accessseur de l'identifiant du Visiteur.
        /// </summary>
        /// <returns></returns>
        public int getId()
        {
            return this.id;
        }
        
        /// <summary>
        /// Accesseur de la liste des visites du Visiteur
        /// </summary>
        /// <returns></returns>
        public List<Visite> getListVisite()
        {
            return this.listVisite;
        }

        /// <summary>
        /// Modificateur de la liste des visites du Visiteur
        /// </summary>
        /// <param name="list"></param>
        public void setListVisite(List<Visite> list)
        {
            this.listVisite = list;
        }

        /// <summary>
        /// Ajouter une visite à la liste des visites du Visiteur
        /// </summary>
        /// <param name="visite"></param>
        public void addVisite(Visite visite)
        {
            this.listVisite.Add(visite);
        }
        
        /// <summary>
        /// ToString de la classe Visiteur
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.getNom()} {this.getPrenom()}";
        }
        
        public string toString()
        {
            return $"id : {this.id}, nom : {this.getNom()}, prenom : {this.getPrenom()}";
        }
    }
}
