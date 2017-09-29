using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquationSolderUnitTests
{
    [TestClass]
    public class GetSolutionsTest
    {
        [TestMethod]
        public void GetSolutions_EquationWithSpecialCoefficients_expectedSolutionsReturned()
        {
            var equation = "3x^2 - 18x + 27 = 0";
            var coefficients = new[] { 3, -18, 27 };
            var expectedSolutions = new[] { 3, 3 };
            var discriminant = 0;
            var typeOfEquation = 0;

            var actualSolutions = GetSolutions(coefficients, discriminant, typeOfEquation);

            CollectionAssert.AreEqual(expectedSolutions, actualSolutions);
        }
    }
}
