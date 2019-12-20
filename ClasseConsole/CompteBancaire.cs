using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseConsole
{
    class CompteBancaire
    {
        /* Attributs */
        private string titulaire;
        private double solde;
        private string devise;
        private int nbComptes;

        /* Getters et setters */
        #region
        public string getTitulaire()
        {
            return titulaire;
        }
        public void setTitulaire(string titulaire)
        {
            this.titulaire = titulaire;
        }

        public double getSolde()
        {
            return solde;
        }
        public void setSolde(double solde)
        {
            this.solde = solde;
        }

        public string getDevise()
        {
            return devise;
        }
        public void setDevise(string devise)
        {
            this.devise = devise;
        }

        public int getNbCompte()
        {
            return nbComptes;
        }
        public void setNbCompte(int nbComptes)
        {
            this.nbComptes = nbComptes;
        }
        #endregion

        /* Constructeur */
        public CompteBancaire(string titulaire, double solde, string devise)
        {
            this.titulaire = titulaire;
            this.solde = solde;
            this.devise = devise;
        }

        /* Méthodes de classe */
        public void Crediter(double montant)
        {
            solde += montant;
        }

        public void Debiter(double montant)
        {
            solde -= montant;
        }

        public string Decrire()
        {
            return "Titulaire : " + titulaire + ", solde : " + solde + ", devise : " + devise;
        }
    }
}
