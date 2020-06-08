using System;
using System.Collections.Generic;
using System.Text;

namespace Exo3
{
    class Article
    {
        private string reference;
        private string designation;
        private double prixHT;
        private const double tauxTVA = 20;

        public string GetReference() { return reference; }
        public void SetReference(string reference) { this.reference = reference; }
        public string GetDesignation() { return designation; }
        public void SetDesignation(string designation) { this.designation = designation; }
        public double GetPrixHT() { return prixHT; }
        public void SetPrixHT(double prixHT) { this.prixHT = prixHT; }
        public double GetTauxTVA() { return tauxTVA; }
        /*public void SetTauxTVA(double tauxTVA) { this.tauxTVA = tauxTVA; }*/

        public Article()
        {

        }

        public Article(string reference, string designation, double prixHT/*, double tauxTVA*/)
        {
            this.reference = reference;
            this.designation = designation;
            this.prixHT = prixHT;
            //this.tauxTVA = tauxTVA;
        }

        public Article(string reference, string designation)
        {
            this.reference = reference;
            this.designation = designation;
        }

        public Article(Article previousArticle)
        {
            this.reference = previousArticle.GetReference();
            this.designation = previousArticle.GetDesignation();
            this.prixHT = previousArticle.GetPrixHT();
            //this.tauxTVA = previousArticle.GetTauxTVA();
        }

        public double CalculerPrixTTC()
        {
            return (prixHT * (prixHT * tauxTVA / 100));
        }

        public string AfficherArticle()
        {
            return "Référence: " + reference + ", désignation: " + designation + ", prixHT: " + prixHT + ", tauxTVA : " + tauxTVA;
        }

    }
}
