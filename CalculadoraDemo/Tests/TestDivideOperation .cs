using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraDemo.tests
{
    public class TestDivideOperation
    {
        [TestMethod]
        public void VerifyDivisionOfPositiveNumbers()
        {
            var expectedResult = 2;
            var firstNumber = 4;
            var secondNumber = 2;

            var resultOfDivision = new Substract(firstNumber, secondNumber).Perform();

            Assert.AreEqual(expectedResult, resultOfDivision, $"The Expected result of Substract should be {expectedResult} But it was: {resultOfDivision}");
        }

        [TestMethod]
        public void VerifyDivisionOfNegativeNumbers()
        {
            var expectedResult = 2;
            var firstNumber = -4;
            var secondNumber = -2;

            var resultOfDivision = new Substract(firstNumber, secondNumber).Perform();

            Assert.AreEqual(expectedResult, resultOfDivision, $"The Expected result of Substract should be {expectedResult} But it was: {resultOfDivision}");
        }

        [TestMethod]
        public void VerifyUndoOfDivisionOfPositiveNumbers()
        {
            var expectedResult = 6;
            var expectedUndo = 1;
            var firstNumber = 8;
            var secondNumber = 2;

            var divisionToTest = new Substract(firstNumber, secondNumber);
            var resultOfDivision = divisionToTest.Perform();
            var resultOfUndo = divisionToTest.Undo();

            Assert.AreEqual(expectedResult, resultOfDivision, $"The Expected result of Substract should be {expectedResult} But it was: {resultOfDivision}");
            Assert.AreEqual(expectedUndo, resultOfUndo, $"The Expected result of Undo in Substract should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }
}
