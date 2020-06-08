using System;

namespace Exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Article article1 = new Article();
            article1.SetReference("article1");
            article1.SetDesignation("ceci est l'article 1");
            article1.SetPrixHT(19.99);
            //article1.SetTauxTVA(20);
            Console.WriteLine("===== Article 1 =====");
            Console.WriteLine(article1.AfficherArticle());
            Console.WriteLine(article1.CalculerPrixTTC() + "Euros");

            Console.WriteLine("===== Article 2 =====");
            Article article2 = new Article("article2", "ceci est l'article 2", 19.99/*, 20*/);
            Console.WriteLine(article2.AfficherArticle());
            Console.WriteLine(article2.CalculerPrixTTC() + "Euros");

            Console.WriteLine("===== Article 3 =====");
            Article article3 = new Article("article3", "ceci est l'article 3");
            article3.SetPrixHT(19.99);
            //article3.SetTauxTVA(20);
            Console.WriteLine(article3.AfficherArticle());
            Console.WriteLine(article3.CalculerPrixTTC() + "Euros");

            Console.WriteLine("===== Article 4 =====");
            Article article4 = new Article(article3);
            Console.WriteLine(article4.AfficherArticle());
            Console.WriteLine(article4.CalculerPrixTTC() + "Euros");


            Console.ReadLine();
        }
    }
}
