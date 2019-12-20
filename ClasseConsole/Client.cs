using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseConsole
{
    class Client
    {
        /* Attributs */
        private string cin;
        private string nom;
        private string prenom;
        private int tel;

        /* Getters et setters */
        #region
        public string getCin()
        {
            return cin;
        }
        public void setCin(string cin)
        {
            this.cin = cin;
        }

        public string getNom()
        {
            return nom;
        }
        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public string getPrenom()
        {
            return prenom;
        }
        public void setPrenom(string prenom)
        {
            this.prenom = prenom;
        }

        public int getTel()
        {
            return tel;
        }
        public void setTel(int tel)
        {
            this.tel = tel;
        }
        #endregion

        /* Constructeur */
        public Client(string cin, string nom, string prenom, int tel)
        {
            this.cin = cin;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
        }

        public Client(string cin, string nom, string prenom)
        {
            this.cin = cin;
            this.nom = nom;
            this.prenom = prenom;
        }

        /* Méthodes de la classe */
        public string Afficher()
        {
            return "Client = CIN : " + cin + ", nom : " + nom + ", prénom : " + prenom + ", téléphone : " + tel;
        }
    }
}
