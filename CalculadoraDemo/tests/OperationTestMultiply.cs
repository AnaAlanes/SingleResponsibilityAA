using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraDemo.tests
{
    public class OperationTestMultiply
    {

        [TestMethod]
        public void VerifySubstractOfPositiveNumbers()
        {
            var expectedMultication = 6;
            var firstNumber = 12;
            var secondNumber = 3;

            var resultOfMultication = new Substract(firstNumber, secondNumber).Perform();

            Assert.AreEqual(expectedMultication, resultOfMultication, $"The Expected result of Substract should be {expectedMultication} But it was: {resultOfMultication}");
        }

        [TestMethod]
        public void VerifySubstractOfNegativeNumbers()
        {
            var expectedMultication = -5;
            var firstNumber = -8;
            var secondNumber = -3;

            var resultOfMultication = new Substract(firstNumber, secondNumber).Perform();

            Assert.AreEqual(expectedMultication, resultOfMultication, $"The Expected result of Substract should be {expectedMultication} But it was: {resultOfMultication}");
        }

        [TestMethod]
        public void VerifyUndoOfSubstractOfPositiveNumbers()
        {
            var expectedMultication = 6;
            var expectedUndo = 1;
            var firstNumber = 7;
            var secondNumber = 5;

            var multicationToTest = new Substract(firstNumber, secondNumber);
            var resultOfmultication = multicationToTest.Perform();
            var resultOfUndo = multicationToTest.Undo();

            Assert.AreEqual(expectedMultication, resultOfmultication, $"The Expected result of Substract should be {expectedMultication} But it was: {resultOfmultication}");
            Assert.AreEqual(expectedUndo, resultOfUndo, $"The Expected result of Undo in Substract should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }
}
