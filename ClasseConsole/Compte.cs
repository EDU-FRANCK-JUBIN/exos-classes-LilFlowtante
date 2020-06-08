namespace ClasseConsole
{
    class Compte
    {
        /* Attributs */
        private double solde;
        private int code = 0;
        private Client proprietaire;

        /* Getters et setters */
        public double GetSolde()
        {
            return solde;
        }

        public int GetNumero()
        {
            return code;
        }

        public Client GetProprietaire()
        {
            return proprietaire;
        }
        public void SetProprietaire(Client proprietaire)
        {
            this.proprietaire = proprietaire;
        }

        /* Constructeur */
        public Compte(Client proprietaire)
        {
            code++;
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
            this.Crediter(somme);
            compte.Debiter(somme);
        }

        public void Debiter(double somme)
        {
            solde -= somme;
        }

        public void Debiter(double somme, Compte compte)
        {
            this.Debiter(somme);
            compte.Crediter(somme);
        }

        public string Afficher()
        {
            return "Compte = Propriétaire : " + GetProprietaire().GetNom() + " " + GetProprietaire().GetPrenom() + ", code : " + code + ", solde : " + solde;
        }
    }
}
