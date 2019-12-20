using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseConsole
{
    class Compte
    {
        /* Attributs */
        private double solde;
        private int numero;
        private Client proprietaire;

        /* Getters et setters */
        public double getSolde()
        {
            return solde;
        }

        public int getNumero()
        {
            return numero;
        }

        public Client getProprietaire()
        {
            return proprietaire;
        }

        /* Constructeur */
        public Compte(Client proprietaire)
        {
            numero++;
            this.proprietaire = proprietaire;
            solde = 0;
        }

        /* Méthodes de la classe */
        public void Crediter(double somme)
        {
            solde += somme;
        }

        public void Crediter(double somme, Compte compte)
        {
            compte.Crediter(somme);
            this.Debiter(somme);
        }

        public void Debiter(double somme)
        {
            solde = solde - somme;
        }

        public void Debiter(double somme, Compte compte)
        {
            compte.Debiter(somme);
            this.Crediter(somme);
        }

        public string Afficher()
        {
            return "Compte = Propriétaire : " + getProprietaire().getNom() + " " + getProprietaire().getPrenom() + ", numéro : " + this.numero + ", solde : " + this.solde;
        }
    }
}
