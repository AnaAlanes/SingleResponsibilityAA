using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraDemo.tests
{
    public class OperationTestSubtract
    {

        [TestMethod]
        public void VerifySubstractOfPositiveNumbers()
        {
            var expectedSubstract = 2;
            var firstNumber = 4;
            var secondNumber = 2;

            var resultOfSubstract = new Substract(firstNumber, secondNumber).Perform();

            Assert.AreEqual(expectedSubstract, resultOfSubstract, $"The Expected result of Substract should be {expectedSubstract} But it was: {resultOfSubstract}");
        }

        [TestMethod]
        public void VerifySubstractOfNegativeNumbers()
        {
            var expectedSubstract = -2;
            var firstNumber = -4; // - 4
            var secondNumber = -2; // + 2

            var resultOfSubstract = new Substract(firstNumber, secondNumber).Perform();

            Assert.AreEqual(expectedSubstract, resultOfSubstract, $"The Expected result of Substract should be {expectedSubstract} But it was: {resultOfSubstract}");
        }

        [TestMethod]
        public void VerifyUndoOfSubstractOfPositiveNumbers()
        {
            var expectedSubstract = 6;
            var expectedUndo = 8;
            var firstNumber = 8;
            var secondNumber = 2;

            var substractToTest = new Substract(firstNumber, secondNumber);
            var resultOfSubstract = substractToTest.Perform();
            var resultOfUndo = substractToTest.Undo();

            Assert.AreEqual(expectedSubstract, resultOfSubstract, $"The Expected result of Substract should be {expectedSubstract} But it was: {resultOfSubstract}");
            Assert.AreEqual(expectedUndo, resultOfUndo, $"The Expected result of Undo in Substract should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }
}
