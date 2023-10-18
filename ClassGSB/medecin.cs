using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGSB
{
    public class Medecin : Personne
    {
        private int id;
        private string mail;
        private string motDePasse;
        private DateTime dateCreation;
        private string rpps;
        private DateTime dateDiplome;
        private DateTime dateConsentement;

        public string Mail { get => mail; set => mail = value; }
        public DateTime DateCreation { get => dateCreation; set => dateCreation = value; }
        public string Rpps { get => rpps; set => rpps = value; }
        public DateTime DateDiplome { get => dateDiplome; set => dateDiplome = value; }

        public Medecin(int id, string nom, string prenom, string mail, string motDePasse, DateTime dateCreation, string rpps, DateTime dateDiplome, DateTime dateConsentement) : base(nom, prenom)
        {
            this.id = id;
            this.mail = mail;
            this.motDePasse = motDePasse;
            this.dateCreation = dateCreation;
            this.rpps = rpps;
            this.dateDiplome = dateDiplome;
            this.dateConsentement = dateConsentement;
        }
        public Medecin(string nom, string prenom, string mail, string motDePasse) : base(nom, prenom)
        {
            this.mail = mail;
            this.motDePasse = motDePasse;
        }
        public Medecin(string nom, string prenom, string mail, string motDePasse,string rpps, DateTime dateDiplome) : base(nom, prenom)
        {
            this.mail = mail;
            this.motDePasse = motDePasse;
            this.rpps = rpps;
            this.dateDiplome = dateDiplome;
        }
        public Medecin(int id) : base("", "")
        {
            this.id = id;
        }

        public Medecin(int id, string nom, string prenom, string mail, string motDePasse, string rpps, DateTime dateDiplome) : base(nom, prenom)
        {
            this.id = id;
            this.mail = mail;
            this.motDePasse = motDePasse;
            this.rpps = rpps;
            this.dateDiplome = dateDiplome;
        }
        public int getId(){
            return id;
        }
        public string getMail(){
            return mail;
        }
        public string getMotDePasse(){
            return motDePasse;
        }
        public DateTime getDateCreation(){
            return dateCreation;
        }
        public string getRpps(){
            return rpps;
        }
        public DateTime getDateDiplome(){
            return dateDiplome;
        } 
        public DateTime getDateConsentement(){
            return dateConsentement;
        }
        public void setId(int id){
            this.id=id;
        }
        public void setMail(string mail){
            this.mail = mail;
        }
        public void setMotDePasse(string motDePasse){
            this.motDePasse = motDePasse;
        }
        public void setDateCreation(DateTime dateCreation){
            this.dateCreation = dateCreation;
        }
        public void setRpps(string rpps){
            this.rpps = rpps;
        }
        public void setDateDiplome(DateTime dateDiplome){
            this.dateDiplome = dateDiplome;
        }
        public void setDateConsentement(DateTime dateConsentement){
            this.dateConsentement = dateConsentement;
        }

        public override string ToString()
        {
            return $"{this.getNom()} {this.getPrenom()}";
        }
        
        public string toString()
        {
            string Text = string.Empty;
            Text = "id : " + this.id;
            Text += " nom : " + this.getNom();
            Text += " prenom : " + this.getNom();
            Text += " mail : " + this.mail;
            Text += " mot de passe : " + this.motDePasse;
            Text += " date de création du compte : " + this.dateCreation;
            Text += " rpps : " + this.rpps + " vous l'avez eu le " + this.dateDiplome;
            Text += " compte validé le :" + this.dateConsentement;

            return Text;
        }
    }
}
