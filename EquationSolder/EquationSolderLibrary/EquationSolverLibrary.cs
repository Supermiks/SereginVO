using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EquationSolverLibrary
{
    public static class EquationSolver
    {
        public static bool IsInputValid(string input)
        {
            input = Regex.Replace(input, @"\s", "");

            string pattern = @"^-?\d+x\^2[+-]\d+x[+-]\d+=0$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(input);
        }

        public static int[] ParseEquation(string input)
        {
            input = Regex.Replace(input, @"\s|x\^2", ""); //Убираем пробелы и "x^2", чтобы степень не была воспринята как коэффициент

            string pattern = @"-?\d+";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            int[] coefficients = new int[3];
            for (int i = 0; i < 3; i++)
            {
                coefficients[i] = int.Parse(match.Value);
                match = match.NextMatch();
            }

            return coefficients;
        }
    }
}
