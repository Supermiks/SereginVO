using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquationSolverLibrary;
using static EquationSolverLibrary.EquationSolver;

namespace EquationSolderUnitTests
{
    [TestClass]
    public class InputValidationTests
    {
        [TestMethod]
        public void IsInputValid_EquationWithNegativeCoefficients_TrueReturned()
        {
            var equation = "-4x^2 + 3x - 15 = 0";

            var flag = IsInputValid(equation);

            Assert.IsTrue(flag);
        }

        public void IsInputValid_EquationWithSpaces_TrueReturned()
        {
            var equation = "  2x ^2    +   3x    +3   =0 ";

            var flag = IsInputValid(equation);

            Assert.IsTrue(flag);
        }

        [TestMethod]
        public void IsInputValid_EquationWithUnnecessarySymbols_FalseReturned()
        {
            var equation = "abc 3x^2 + 2x + 3 = 0";

            var flag = IsInputValid(equation);

            Assert.IsFalse(flag);
        }

        [TestMethod]
        public void IsInputValid_EquationNotEqualToZero_FalseReturned()
        {
            var equation = "3x^2 + 2x + 3 = 12";

            var flag = IsInputValid(equation);

            Assert.IsFalse(flag);
        }

        [TestMethod]
        public void IsInputValid_NotQuadraticEquation_FalseReturned()
        {
            var equation = "2x + 3 = 12";

            var flag = IsInputValid(equation);

            Assert.IsFalse(flag);
        }

        [TestMethod]
        public void IsInputValid_EquationWithWrongSign_FalseReturned()
        {
            var equation = "3x^2 * 2x - 3 = 12";

            var flag = IsInputValid(equation);

            Assert.IsFalse(flag);
        }
    }
}
