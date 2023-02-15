using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraDemo.tests
{
    public class OperationTestDivide
    {
        [TestMethod]
        public void VerifySubstractOfPositiveNumbers()
        {
            var expectedDivision = 2;
            var firstNumber = 4;
            var secondNumber = 2;

            var resultOfDivision = new Substract(firstNumber, secondNumber).Perform();

            Assert.AreEqual(expectedDivision, resultOfDivision, $"The Expected result of Substract should be {expectedDivision} But it was: {resultOfDivision}");
        }

        [TestMethod]
        public void VerifySubstractOfNegativeNumbers()
        {
            var expectedDivision = -6;
            var firstNumber = -4;
            var secondNumber = -2;

            var resultOfDivision = new Substract(firstNumber, secondNumber).Perform();

            Assert.AreEqual(expectedDivision, resultOfDivision, $"The Expected result of Substract should be {expectedDivision} But it was: {resultOfDivision}");
        }

        [TestMethod]
        public void VerifyUndoOfSubstractOfPositiveNumbers()
        {
            var expectedDivision = 6;
            var expectedUndo = 1;
            var firstNumber = 8;
            var secondNumber = 2;

            var divisionToTest = new Substract(firstNumber, secondNumber);
            var resultOfDivision = divisionToTest.Perform();
            var resultOfUndo = divisionToTest.Undo();

            Assert.AreEqual(expectedDivision, resultOfDivision, $"The Expected result of Substract should be {expectedDivision} But it was: {resultOfDivision}");
            Assert.AreEqual(expectedUndo, resultOfUndo, $"The Expected result of Undo in Substract should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }
}
