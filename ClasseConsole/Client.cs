namespace ClasseConsole
{
    class Client
    {
        private string cin;
        private string nom;
        private string prenom;
        private int tel;

        public string GetCin() { return cin; }
        public void SetCin(string cin) { this.cin = cin; }
        public string GetNom() { return nom; }
        public void SetNom(string nom) { this.nom = nom; }
        public string GetPrenom() { return prenom; }
        public void SetPrenom(string prenom) { this.prenom = prenom; }
        public int GetTel() { return tel; }
        public void SetTel(int tel) { this.tel = tel; }

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

        public string Afficher()
        {
            return "Client = CIN : " + cin + ", nom : " + nom + ", prénom : " + prenom + ", téléphone : " + tel;
        }
    }
}
