using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Globalization;

namespace ClassGSB
{
    
    public static class passerelle
    {
        private static List<Medecin> listMedecins = new List<Medecin>();
        private static List<Visiteur> listVisiteurs = new List<Visiteur>();
        private static List<Visite> listVisites = new List<Visite>();

        private static string baseUri = "http://127.0.0.2/";

        public static HttpClient httpClient = new HttpClient();

        /// <summary>
        /// Initialise toutes les listes.
        /// </summary>
        public static void setAll()
        {
            setListMedecin();
            setListVisiteur();
            setListVisite();
        }

        //
        //partie Visiteur :
        //

        /// <summary>
        /// Initialise la liste visiteur.
        /// </summary>
        public static async Task<List<Visiteur>> setListVisiteur()
        {
            listVisiteurs.Clear();

            /*listVisiteurs.Add(new Visiteur(1, "lefrevre", "miguel"));
            listVisiteurs.Add(new Visiteur(2, "monpart", "jessica"));
            listVisiteurs.Add(new Visiteur(3, "haute", "sage"));
            listVisiteurs.Add(new Visiteur(4, "dyq", "derek"));
            listVisiteurs.Add(new Visiteur(5, "dehaisse", "jill"));
            listVisiteurs.Add(new Visiteur(6, "trialfa", "chad"));
            listVisiteurs.Add(new Visiteur(7, "bobsi", "isabella"));
            listVisiteurs.Add(new Visiteur(8, "rossie", "stephen"));
            listVisiteurs.Add(new Visiteur(9, "rossie", "jade"));
            listVisiteurs.Add(new Visiteur(10, "josy", "maya"));*/

            var res = await httpClient.GetStringAsync($"{baseUri}API/visiteur.php");

            dynamic jsonResult = JsonConvert.DeserializeObject(res);

            foreach (var visiteur in jsonResult)
            {
                listVisiteurs.Add(new Visiteur(visiteur.idVisiteur.ToObject<int>(), visiteur.nom.ToObject<string>(), visiteur.prenom.ToObject<string>()));
            }

            return listVisiteurs;
        }

        /// <summary>
        /// Renvoi la liste des visiteurs.
        /// </summary>
        /// <returns>List<Visiteur></Visiteur></returns>
        public static  async Task<List<Visiteur>> getLesVisiteurs()
        {
            return await setListVisiteur();
        }

        /// <summary>
        /// Renvoi un visiteur par ID.
        /// </summary>
        /// <returns>Visiteur</returns>
        public static Visiteur getVisiteurByID(int id)
        {
            return listVisiteurs.Find(x => x.getId() == id);
        }

        /// <summary>
        /// Ajoute un visiteur à la liste.
        /// </summary>
        /// <param name="visiteur"></param>
        public static void addVisteur(Visiteur visiteur)
        {
            FormUrlEncodedContent content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                  { "nom", visiteur.getNom().ToString() },
                  { "prenom", visiteur.getPrenom().ToString() }
            });

            httpClient.PostAsync($"{baseUri}API/visiteur.php", content);
            listVisiteurs.Add(visiteur);
        }
        
        /// <summary>
        /// Modifie les information du visiteur.
        /// </summary>
        /// <param name="visiteur"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        public static async Task<bool> modifVisiteur(Visiteur visiteur, string nom, string prenom)
        {
            FormUrlEncodedContent content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                  { "idVisiteur", visiteur.getId().ToString() },
                  { "nom", nom },
                  { "prenom", prenom },
            });

            await httpClient.PutAsync($"{baseUri}API/visiteur.php", content);

            return true;
        }

        /// <summary>
        /// Supprime le visiteur de la liste.
        /// </summary>
        /// <param name="visiteur"></param>
        public static void delVisiteur(Visiteur visiteur)
        {
            httpClient.DeleteAsync($"{baseUri}API/visiteur.php?idVisiteur={visiteur.getId()}");
            listVisiteurs.Remove(visiteur);
        }

        //
        //partie medecin : (sanders)
        //

        /// <summary>
        /// Initialise la liste Medecins.
        /// </summary>
        public static async Task<List<Medecin>> setListMedecin()
        {
            listMedecins.Clear();
            /*listMedecins.Add(new Medecin(1,"Zoey","verif","test@test.test","Azerty@123456789",new DateTime(2023-05-04),"NULL",new DateTime(2022-04-05), new DateTime(2023 - 01 - 01)));
            listMedecins.Add(new Medecin(2,"Melanie","sarah", "test@test.test", "Azerty@123456789", new DateTime(2023 - 05 - 04), "NULL", new DateTime(2022 - 04 - 05), new DateTime(2023 - 01 - 01)));
            listMedecins.Add(new Medecin(3,"Magnar","de", "test@test.test", "Azerty@123456789", new DateTime(2023 - 05 - 04), "NULL", new DateTime(2022 - 04 - 05), new DateTime(2023 - 01 - 01)));
            listMedecins.Add(new Medecin(4,"Lucas","fernades", "test@test.test", "Azerty@123456789", new DateTime(2023 - 05 - 04), "NULL", new DateTime(2022 - 04 - 05), new DateTime(2023 - 01 - 01)));
            listMedecins.Add(new Medecin(5,"John","Boy", "test@test.test", "Azerty@123456789", new DateTime(2023 - 05 - 04), "NULL", new DateTime(2022 - 04 - 05), new DateTime(2023 - 01 - 01)));
            listMedecins.Add(new Medecin(6,"Caleb","alpha", "test@test.test", "Azerty@123456789", new DateTime(2023 - 05 - 04), "NULL", new DateTime(2022 - 04 - 05), new DateTime(2023 - 01 - 01)));
            listMedecins.Add(new Medecin(7,"Elena","elbyoy", "test@test.test", "Azerty@123456789", new DateTime(2023 - 05 - 04), "NULL", new DateTime(2022 - 04 - 05), new DateTime(2023 - 01 - 01)));
            listMedecins.Add(new Medecin(8,"Bianca","lova", "test@test.test", "Azerty@123456789", new DateTime(2023 - 05 - 04), "NULL", new DateTime(2022 - 04 - 05), new DateTime(2023 - 01 - 01)));
            listMedecins.Add(new Medecin(9,"Jill","royce", "test@test.test", "Azerty@123456789", new DateTime(2023 - 05 - 04), "NULL", new DateTime(2022 - 04 - 05), new DateTime(2023 - 01 - 01)));
            listMedecins.Add(new Medecin(10,"Tiffani","holle", "test@test.test", "Azerty@123456789", new DateTime(2023 - 05 - 04), "NULL", new DateTime(2022 - 04 - 05),new DateTime(2023 - 01 -01)));*/

                var res = await httpClient.GetStringAsync($"{baseUri}API/medecin.php");

                dynamic jsonResult = JsonConvert.DeserializeObject(res);

                foreach (var medecin in jsonResult)
                {
                    listMedecins.Add(new Medecin(medecin.idmedecin.ToObject<int>(), medecin.nom.ToObject<string>(), medecin.prenom.ToObject<string>(), medecin.mail.ToObject<string>(), medecin.motDePasse.ToObject<string>(), DateTime.Now, medecin.rpps.ToObject<string>(), medecin.dateDiplome.ToObject<DateTime>(), DateTime.Now));
                }

                return listMedecins;
        }


        /// <summary>
        /// Renvoi la liste des medecins.
        /// </summary>
        /// <returns>List<Medecin></returns>

        public static async Task<List<Medecin>> getLesMedecins()
        {
            return await setListMedecin();
        }

        /// <summary>
        /// Renvoi un medecin par ID.
        /// </summary>
        /// <returns>Medecin</returns>
        public static Medecin getMedecinByID(int id)
        {
            return listMedecins.Find(x => x.getId() == id);
        }

        /// <summary>
        /// Ajoute un Medecin à la liste.
        /// </summary>
        /// <param name="medecin"></param>
        public static async Task<bool> addMedecin(Medecin medecin)
        {
            FormUrlEncodedContent content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                  { "nom", medecin.getNom().ToString() },
                  { "prenom", medecin.getPrenom().ToString() },
                  { "mail", medecin.getMail().ToString() },
                  { "motDePasse", medecin.getMotDePasse().ToString() },
                  { "dateCreation", DateTime.Now.ToString("yyyy-MM-dd") },
                  { "rpps", medecin.getRpps().ToString() },
                  { "dateDiplome", medecin.getDateDiplome().ToString("yyyy-MM-dd") }
            });

            var response = await httpClient.PostAsync($"{baseUri}API/medecin.php", content);
            //var responseString = await response.Content.ReadAsStringAsync();

            return true;
        }

        /// <summary>
        /// Modifie les information du medecin.
        /// </summary>
        /// <param name="medecin"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="mail"></param>
        /// <param name="pwd"></param>
        public static async Task<bool> modifMedecin(Medecin medecin,string nom,string prenom,string mail,string pwd)
        {
            FormUrlEncodedContent content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                  { "idMedecin", medecin.getId().ToString() },
                  { "nom", nom },
                  { "prenom", prenom },
                  { "mail", mail },
                  { "motDePasse", pwd },
            });
            await httpClient.PutAsync($"{baseUri}API/medecin.php", content);

            return true;
        }

        /// <summary>
        /// Supprime le medecin de la liste.
        /// </summary>
        /// <param name="medecin"></param>
        public static void delMedecin(Medecin medecin)
        {
            httpClient.DeleteAsync($"{baseUri}API/medecin.php?id={medecin.getId()}");
        }

        /// <summary>
        /// Initialise la liste des médecins
        /// </summary>
        public static async Task<List<Visite>> setListVisite()
        {
            listVisites.Clear();

            /*listVistes.Add(new Visite(1, new Medecin("sanders", "james", "no-reply@gmail.com", "azerty123"), new Visiteur(1, "lefrevre", "miguel"), "adresse1", new DateTime(2015, 12, 12)));
            listVistes.Add(new Visite(new Medecin("derek", "dyq", "no-reply@gmail.com", "azerty123"), new Visiteur(2, "monpart", "jessica"), "adresse2", new DateTime(2015, 12, 12)));
            listVistes.Add(new Visite(3, new Medecin("sage", "haute", "no-reply@gmail.com", "azerty123"), new Visiteur(3, "haute", "sage"), "adresse3", new DateTime(2015, 12, 12)));
            listVistes.Add(new Visite(new Medecin("derek", "dyq", "no-reply@gmail.com", "azerty123"), new Visiteur(4, "Jade", "Say-xe"), "adresse4", new DateTime(2015, 12, 12)));
            listVistes.Add(new Visite(5, new Medecin("jill", "dehaisse", "no-reply@gmail.com", "azerty123"), new Visiteur(5, "dehaisse", "jill"), "adresse5", new DateTime(2015, 12, 12)));
            listVistes.Add(new Visite(new Medecin("chad", "trialfa", "no-reply@gmail.com", "azerty123"), new Visiteur(6, "trialfa", "chad"), "adresse6", new DateTime(2015, 12, 12)));*/

            var response = await httpClient.GetStringAsync($"{baseUri}API/visite.php");

            dynamic jsonResult = JsonConvert.DeserializeObject(response);

            foreach (var visite in jsonResult.data)
            {
                Medecin medecin = passerelle.getMedecinByID(visite.idMedecin.ToObject<int>());
                Visiteur visiteur = passerelle.getVisiteurByID(visite.idVisiteur.ToObject<int>());

                Visite v = new Visite(visite.idVisite.ToObject<int>(), medecin, visiteur, visite.adresse.ToObject<string>(), visite.dateVisite.ToObject<DateTime>());
                listVisites.Add(v);
            }

            return listVisites;
        }

        /// <summary>
        /// Renvoi la liste des visites
        /// </summary>
        /// <returns> List<Visite> </returns>
        public static async Task<List<Visite>> getLesVisites()
        {
            return await setListVisite();
        }

        /// <summary>
        /// Ajoute une visite à la liste
        /// </summary>
        /// <param name="visite"> Visite </param>
        public static async Task<Boolean> addVisite(Visite visite)
        {
            DateTime date = visite.DateVisite;
            string dateString = $"{date.Year}-";
            if (date.Month < 10)
            {
                dateString += $"0{date.Month}-";
            }
            else
            {
                dateString += $"{date.Month}-";
            }

            if (date.Day < 10)
            {
                dateString += $"0{date.Day} ";
            }
            else
            {
                dateString += $"{date.Day} ";
            }

            if (date.Hour < 10)
            {
                dateString += $"0{date.Hour}:";
            }
            else
            {
                dateString += $"{date.Hour}:";
            }

            if (date.Minute < 10)
            {
                dateString += $"0{date.Minute}:";
            }
            else
            {
                dateString += $"{date.Minute}:";
            }

            if (date.Second < 10)
            {
                dateString += $"0{date.Second}";
            }
            else
            {
                dateString += $"{date.Second}";
            }


            var content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                  { "idMedecin", visite.getMedecin().getId().ToString() },
                  { "idVisiteur", visite.getVisiteur().getId().ToString() },
                  { "adresse", visite.getAdresse() },
                //{ "dateVisite", visite.getDateVisite().ToString("g", (new CultureInfo("zh-CN")).DateTimeFormat) },
                  { "dateVisite", dateString }
            }); ;
            
            //var response = await httpClient.PostAsync($"{baseUri}API/visite.php", content);
            await httpClient.PostAsync($"{baseUri}API/visite.php", content);
            // messagebox response body
            //var responseString = await response.Content.ReadAsStringAsync();
            
            listVisites.Add(visite);
            return true;
        }

        /// <summary>
        /// Modifie une visite
        /// </summary>
        /// <param name="visite">Visite</param>

        public static async Task<Boolean> modVisite(Visite visite)
        {
            DateTime date = visite.DateVisite;
            string dateString = $"{date.Year}-";
            if (date.Month < 10)
            {
                dateString += $"0{date.Month}-";
            }
            else
            {
                dateString += $"{date.Month}-";
            }

            if (date.Day < 10)
            {
                dateString += $"0{date.Day} ";
            }
            else
            {
                dateString += $"{date.Day} ";
            }

            if (date.Hour < 10)
            {
                dateString += $"0{date.Hour}:";
            }
            else
            {
                dateString += $"{date.Hour}:";
            }

            if (date.Minute < 10)
            {
                dateString += $"0{date.Minute}:";
            }
            else
            {
                dateString += $"{date.Minute}:";
            }

            if (date.Second < 10)
            {
                dateString += $"0{date.Second}";
            }
            else
            {
                dateString += $"{date.Second}";
            }

            var content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                  { "idVisite", visite.getId().ToString() },
                  { "idMedecin", visite.getMedecin().getId().ToString() },
                  { "idVisiteur", visite.getVisiteur().getId().ToString() },
                  { "adresse", visite.getAdresse() },
                //{ "dateVisite", visite.getDateVisite().ToString("g", (new CultureInfo("zh-CN")).DateTimeFormat) },
                  { "dateVisite", dateString }
            }); ;

            var response = await httpClient.PutAsync($"{baseUri}API/visite.php", content);
            //await httpClient.PutAsync($"{baseUri}API/visite.php", content);
            // messagebox response body
            // var responseString = await response.Content.ReadAsStringAsync();

            return true;
        }


        /// <summary>
        /// Supprime une visite de la liste
        /// </summary>
        /// <param name="visite"> Visite </param>
        public static async Task<Boolean> delVisite(Visite visite)
        {
            await httpClient.DeleteAsync($"{baseUri}API/visite.php?idVisite={visite.getId()}");
            listVisites.Remove(visite);
            return true;
        }
    }
}

    

