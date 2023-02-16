using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraDemo.tests
{
    public class TestMultiplicationOperation
    {

        [TestMethod]
        public void VerifyMultiplicationOfPositiveNumbers()
        {
            var expectedResult = 6;
            var firstNumber = 12;
            var secondNumber = 3;

            var resultOfMultication = new Substract(firstNumber, secondNumber).Perform();

            Assert.AreEqual(expectedResult, resultOfMultication, $"The Expected result of Substract should be {expectedResult} But it was: {resultOfMultication}");
        }

        [TestMethod]
        public void VerifyMultiplicationOfNegativeNumbers()
        {
            var expectedResult = -5;
            var firstNumber = -8;
            var secondNumber = -3;

            var resultOfMultication = new Substract(firstNumber, secondNumber).Perform();

            Assert.AreEqual(expectedResult, resultOfMultication, $"The Expected result of Substract should be {expectedResult} But it was: {resultOfMultication}");
        }

        [TestMethod]
        public void VerifyUndoOfMultiplicationOfPositiveNumbers()
        {
            var expectedResult = 6;
            var expectedUndo = 1;
            var firstNumber = 7;
            var secondNumber = 5;

            var multicationToTest = new Substract(firstNumber, secondNumber);
            var resultOfmultication = multicationToTest.Perform();
            var resultOfUndo = multicationToTest.Undo();

            Assert.AreEqual(expectedResult, resultOfmultication, $"The Expected result of Substract should be {expectedResult} But it was: {resultOfmultication}");
            Assert.AreEqual(expectedUndo, resultOfUndo, $"The Expected result of Undo in Substract should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }
}
