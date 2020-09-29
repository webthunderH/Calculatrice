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
            Welcome();
            var possibleEquations = new List<string>() { };
            string toContinue = string.Empty;
            Calcul(possibleEquations);

            EndOfApplciation();
        }

        private static void Calcul(List<string> possibleEquations)
        {
            string toContinue;
            do
            {
                var expressionEquation = new ExpressionEquation();
                var equation = GetEquation(possibleEquations);
                while (expressionEquation.TesterEquation(equation))
                {
                    Console.WriteLine("Veuillez indiquer une équation correcte svp");
                    equation = GetEquation(possibleEquations);
                }

                Console.WriteLine(expressionEquation.ExecuteCalculation(equation));
                Console.WriteLine("Pour continuer votre veuillez entrer Y/y si vous désirez arrêter veuillez entrer N/n");
                toContinue = Console.ReadLine();
                while (toContinue != yes && toContinue != no)
                {
                    Console.WriteLine("Vous avez fait une entrée invalide.");
                    Console.WriteLine("Pour continuer votre veuillez entrer Y/y si vous désirez arrêter veuillez entrer N/n");
                    toContinue = Console.ReadLine();
                }
            } while (toContinue.ToLower() == yes);
        }

        private static void EndOfApplciation()
        {
            Console.WriteLine("Vous avez terminez merci de votre utilisation. Bonne journée.");
            Console.WriteLine("Pour terminer l'application appuyer sur n'importe quel touche");
            Console.ReadLine();
        }

        private static string GetEquation(List<string> possibleEquations)
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
            return equation;
        }

        private static void Welcome()
        {
            Console.WriteLine("Bonjour à vous, vous êtes dans une calculatrice qui utilise des chaînes de caractère.");
            Console.WriteLine("Je vous invite donc à placer une équation");
            Console.WriteLine("Les équations possible ? Si vous désirez savoir ce que vous pouvez faire entrer help");
        }
    }
}
