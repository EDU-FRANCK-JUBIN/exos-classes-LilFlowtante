using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Calculer les expressions suivantes");
            double sum = 12 + (5 * 12.5) - 1253.68;
            Console.WriteLine("12 + 5 * 12.5 - 1253.68 = " + sum);
            double moyenne = (1.0 + 5.5 + 9.9 + 2.8 + 9.6) / 5;
            Console.WriteLine("Moyenne {1.0 , 5.5 , 9.9 , 2.8 , 9.6} = " + moyenne);
            Console.ReadLine();

            Console.WriteLine("2. Demander à l'utilisateur une valeur de rayon et calculer");
            Console.WriteLine("Choisissez une valeur de rayon :");
            int rayon = int.Parse(Console.ReadLine());
            double perimetre = 2 * Math.PI * rayon;
            Console.WriteLine("Périmètre du cercle = " + perimetre);
            double surface = Math.PI * Math.Pow(rayon, 2);
            Console.WriteLine("Surface du cercle = " + surface);
            Console.ReadLine();

            Console.WriteLine("Saisir une chaîne de 5 caractères : ");
            string chaine = Console.ReadLine();
            StringBuilder newString = new StringBuilder();
            for(int i = 0; i < chaine.Length; i++)
            {
                int car = (int)chaine[i];
                int z = (int)'z';
                if ((car + 3) > z)
                {
                    newString.Append(Convert.ToChar(97 + 2));
                }
                else
                {
                    newString.Append(Convert.ToChar(car + 3));
                }
            }
            Console.WriteLine(newString);
            Console.ReadLine();

            Console.WriteLine("Exercices sur les collections :");
            Console.WriteLine();

            Console.WriteLine("Tableaux :");
            Console.WriteLine();
            int[] ages = { 5, 10, 15, 20, 25, 30 };
            string[] prenoms = { "Louis", "Maxime", "Vincent", "Aurélien", "Hugo", "Marjorie" };
            Console.WriteLine("Prénom : âge");
            for(int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine(prenoms[i] + " : " + ages[i]);
            }
            Console.ReadLine();

            Console.WriteLine("Listes :");
            Console.WriteLine();
            var fruits = new List<string> { "Fraise", "Kiwi", "Orange" };
            fruits.Add("Framboise");
            fruits.Add("Banane");
            fruits.Add("Pomme");
            fruits.Add("Poire");
            fruits.Add("Prune");
            fruits.Remove("Banane");
            foreach(var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.ReadLine();
        }
    }
}
