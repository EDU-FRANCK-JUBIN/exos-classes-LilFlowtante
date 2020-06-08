namespace ClasseConsole
{
    class CompteBancaire
    {
        private string titulaire;
        private double solde;
        private string devise;
        private int nbComptes;

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

        public CompteBancaire(string titulaire, double solde, string devise)
        {
            this.titulaire = titulaire;
            this.solde = solde;
            this.devise = devise;
        }

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
