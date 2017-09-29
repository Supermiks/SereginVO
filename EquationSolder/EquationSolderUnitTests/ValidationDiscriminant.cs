using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquationSolverLibrary;
using static EquationSolverLibrary.EquationSolver;

namespace EquationSolderUnitTests
{
    [TestClass]
    public class ValidationDiscriminant
    {
        [TestMethod]
        public void ValidationDiscriminant_EquationWithNegativeDiscriminant_ExpectedTypeReturned()
        {
            var discriminant = -23;

            var typeOfEquation = ValidationDiscriminant(discriminant);

            Assert.AreEqual(-1, typeOfEquation);
        }
    }
}
