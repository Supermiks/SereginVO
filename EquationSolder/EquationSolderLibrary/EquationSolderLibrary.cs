using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EquationSolderLibrary
{
    public static class EquationSolder
    {
        public static bool IsInputValid(string input)
        {
            input = Regex.Replace(input, @"\s", "");

            string pattern = @"^-?\d+x\^2[+-]\d+x[+-]\d+=0$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(input);
        }

        
    }
}
