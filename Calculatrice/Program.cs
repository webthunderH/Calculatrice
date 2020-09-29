using System;
using System.Collections.Generic;

namespace Calculatrice
{
    class Program
    {
        public const string yes = "y";
        public const string no = "n";
        public const string help = "help";
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour à vous, vous êtes dans une calculatrice qui utilise des chaînes de caractère.");
            Console.WriteLine("Je vous invite donc à placer une équation");
            Console.WriteLine("Les équations possible ? Si vous désirez savoir ce que vous pouvez faire entrer help");
            var possibleEquations = new List<string>() { };
            string toContinue = string.Empty;
            do
            {
                Console.WriteLine("Veuillez inséré une équation");
                var equation = Console.ReadLine();
                while (equation == help)
                {
                    Console.WriteLine("Voici ce que vous pouvez faire : ");
                    foreach (var possibleEquation in possibleEquations)
                    {
                        Console.WriteLine($"-{possibleEquation}");
                    }
                    equation = Console.ReadLine();
                }

                Console.WriteLine("Pour continuer votre veuillez entrer Y/y si vous désirez arrêter veuillez entrer N/n");
                toContinue = Console.ReadLine();
                while (toContinue != yes && toContinue != no)
                {
                    Console.WriteLine("Vous avez fait une entrée invalide.");
                    Console.WriteLine("Pour continuer votre veuillez entrer Y/y si vous désirez arrêter veuillez entrer N/n");
                    toContinue = Console.ReadLine();
                }
            } while (toContinue.ToLower() == yes);

            Console.WriteLine("Vous avez terminez merci de votre utilisation. Bonne journée.");
            Console.ReadLine();
        }
    }
}
