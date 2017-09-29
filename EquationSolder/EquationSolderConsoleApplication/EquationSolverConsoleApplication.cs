using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquationSolverLibrary;
using static EquationSolverLibrary.EquationSolver;

namespace EquationSolverConsoleApplication
{
    class EquationSolverConsoleApplication
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[] coefficients = new int[3];
                string input = GetEquation();

                while (!IsInputValid(input))
                {
                    Console.WriteLine("Неверный ввод, попробуйте ещё раз");
                    input = GetEquation();
                }

                coefficients = ParseEquation(input);
                for (int i = 0; i <3; i++)
                {
                    Console.WriteLine(coefficients[i]);
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
