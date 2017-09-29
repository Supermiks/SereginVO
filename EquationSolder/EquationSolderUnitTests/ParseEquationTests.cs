using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquationSolverLibrary;
using static EquationSolverLibrary.EquationSolver;

namespace EquationSolderUnitTests
{
    [TestClass]
    public class ParseEquationTests
    {
        [TestMethod]
        public void ParseEquation_EquationWithNegativeCoefficients_expectedCoefficientsReturned()
        {
            var equation = "-4x^2 + 3x - 15 = 0";
            var expectedCoefficients = new[] { -4, 3, -15 };

            var actualCoefficients = ParseEquation(equation);

            CollectionAssert.AreEqual(expectedCoefficients, actualCoefficients);
        }

        public void ParseEquation_EquationWithSpecialCoefficients_expectedCoefficientsReturned()
        {
            var equation = "1x^2 - 0x - 1 = 0";
            var expectedCoefficients = new[] { 1, 0, -1 };

            var actualCoefficients = ParseEquation(equation);

            CollectionAssert.AreEqual(expectedCoefficients, actualCoefficients);
        }
    }
}
