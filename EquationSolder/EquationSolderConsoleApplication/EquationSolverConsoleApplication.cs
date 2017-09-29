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
                double[] solutions = new double[2];
                int discriminant;
                int typeOfEquation;


                string input = GetEquation();

                while (!IsInputValid(input))
                {
                    Console.WriteLine("Неверный ввод, попробуйте ещё раз");
                    input = GetEquation();
                }

                coefficients = ParseEquation(input);
                discriminant = CalculateDiscriminant(coefficients);
                typeOfEquation = ValidationDiscriminant(discriminant);

                if (typeOfEquation == -1)
                {
                    Console.WriteLine("Нет решений");
                }
                else
                {
                    solutions = GetSolutions(coefficients, discriminant, typeOfEquation);
                    PrintSolutions(solutions);
                }
            }
        }

        public static string GetEquation()
        {
            Console.WriteLine("Введите уравнение вида ax^2 + bx + c = 0");
            return Console.ReadLine();
        }

        static void PrintSolutions(double[] solutions)
        {
            Console.WriteLine("Корни уравнения");

            foreach (var solution in solutions)
            {
                Console.WriteLine(solution);
            }
        }
    }
}
