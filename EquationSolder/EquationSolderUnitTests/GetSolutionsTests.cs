using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquationSolverLibrary;
using static EquationSolverLibrary.EquationSolver;


namespace EquationSolderUnitTests
{
    [TestClass]
    public class GetSolutionsTests
    {
        [TestMethod]
        public void GetSolutions_EquationWithSpecialCoefficients_expectedSolutionsReturned()
        {
            var equation = "3x^2 - 18x + 27 = 0";
            var coefficients = new[] { 3, -18, 27 };
            double[] expectedSolutions = new double[] { 3, 3};
            var discriminant = 0;
            var typeOfEquation = 0;

            var actualSolutions = GetSolutions(coefficients, discriminant, typeOfEquation);

            CollectionAssert.AreEqual(expectedSolutions, actualSolutions);
        }
    }
}
