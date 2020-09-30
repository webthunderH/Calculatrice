using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculatrice
{
    public class ExpressionEquation
    {
        private const char multiplication = '*';
        private const char division = '/';
        private const char addition = '+';
        private const char substraction = '-';
        private const char modulo = '%';
        private const char bracketOpening = '(';
        private const char bracketEnding = ')';
        private Regex Regex;
        public static string RegexEquation = @"(?<udouble>\(?\-?\d+,\d+\s+[\+\-\*\%\/]\s+\-?\d+,\d)\)?|(?<uint>\(?\-?\d+\s+[\+\-\*\%\/]\s+\-?\d+)\)?";
        public Regex myRegex 
        {
            get
            {
                if (Regex == null)
                {
                    Regex = new Regex(RegexEquation);
                }
                return Regex;
            }
        }

        public bool TesterEquation(string stringATester)
        {
            var lengthTest = 0;
            Regex.Matches(stringATester).ToList().ForEach(a => lengthTest += a.Value.Length);
            return lengthTest == stringATester.Length;
        }

        public string ExecuteCalculation(string equation)
        {

            return "J'ai effectuer le calcul";
        }

        private double Calculate(double a, double b, string operation)
        {
            return 0;
        }

        private IEnumerable<string> FindAllExpression(string equations)
        {
            var retour = new List<string>();
            foreach (var equation in Regex.Split(equations))
            {
                retour.Add(equation);
            }
            return retour.OrderBy(od => od.Contains(bracketOpening) || od.Contains(bracketEnding)).ThenBy(tb => tb.Contains(multiplication) || tb.Contains(division) || tb.Contains(modulo));
        }
    }
}
