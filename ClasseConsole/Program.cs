using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nouveau client :");
            Console.WriteLine("CIN :");
            string cin = Console.ReadLine();
            Console.WriteLine("Nom :");
            string nom = Console.ReadLine();
            Console.WriteLine("Prénom :");
            string prenom = Console.ReadLine();
            Console.WriteLine("Tél :");
            int tel = int.Parse(Console.ReadLine());
            Client newClient = new Client(cin, nom, prenom, tel);
            Console.WriteLine(newClient.Afficher());
            Console.WriteLine();

            Console.WriteLine("Compte 1 :");
            Compte compte1 = new Compte(newClient);
            compte1.Crediter(300);
            Console.WriteLine(compte1.Afficher());
            Console.WriteLine();

            Console.WriteLine("Compte 2 :");
            Compte compte2 = new Compte(newClient);
            compte2.Crediter(525.56);
            Console.WriteLine(compte2.Afficher());
            Console.WriteLine();

            Console.WriteLine("Créditer de 123,3 euros le compte 1 avec le compte 2 :");
            compte2.Crediter(123.3, compte1);
            Console.WriteLine("Nouveau solde du compte 1 :");
            Console.WriteLine(compte1.getSolde() + " euros");
            Console.WriteLine();
            Console.WriteLine("Nouveau solde du compte 2 :");
            Console.WriteLine(compte2.getSolde() + " euros");

            Console.ReadLine();
        }
    }
}
