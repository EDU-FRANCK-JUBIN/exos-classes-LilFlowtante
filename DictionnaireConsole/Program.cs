using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionnaireConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionnaires :");
            Console.WriteLine();
            Dictionary<string, int> dico = new Dictionary<string, int>();
            dico.Add("Louis", 21);
            dico.Add("Maxime", 22);
            dico.Add("Vincent", 21);
            dico.Add("Aurélien", 21);
            dico.Add("Hugo", 21);
            dico.Add("Marjorie", 19);
        }
    }
}
