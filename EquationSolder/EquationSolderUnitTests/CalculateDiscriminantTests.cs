using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquationSolverLibrary;
using static EquationSolverLibrary.EquationSolver;

namespace EquationSolderUnitTests
{
    [TestClass]
    public class CalculateDiscriminantTests
    {
        [TestMethod]
        public void CalculateDiscriminant_EquationWithNegativeDiscriminant_expectedDiscriminantReturned()
        {
            var equation = "-4x^2 + 3x - 2 = 0";
            var coefficients = new[] { -4, 3, -2 };
            var expectedDiscriminant = -23;

            var actualDiscriminant = CalculateDiscriminant(coefficients);

            Assert.AreEqual(expectedDiscriminant, actualDiscriminant);
        }
    }
}
