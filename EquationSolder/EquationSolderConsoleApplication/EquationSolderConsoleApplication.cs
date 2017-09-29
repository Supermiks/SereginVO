using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquationSolderLibrary;
using static EquationSolderLibrary.EquationSolder;

namespace EquationSolderConsoleApplication
{
    class EquationSolderConsoleApplication
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = GetEquation();

                while (!IsInputValid(input))
                {
                    Console.WriteLine("Пошёл нахуй");
                    input = GetEquation();
                }
            }
        }

        public static string GetEquation()
        {
            Console.WriteLine("Введите уравнение вида ax^2 + bx + c = 0");
            return Console.ReadLine();
        }
    }
}
