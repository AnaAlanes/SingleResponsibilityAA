using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraDemo.tests
{
    public class TestSubstractOperation
    {

        [TestMethod]
        public void VerifySubtractionOfPositiveNumbers()
        {
            var expectedResult = 2;
            var firstNumber = 4;
            var secondNumber = 2;

            var resultOfSubstract = new Substract(firstNumber, secondNumber).Perform();

            Assert.AreEqual(expectedResult, resultOfSubstract, $"The Expected result of Substract should be {expectedResult} But it was: {resultOfSubstract}");
        }

        [TestMethod]
        public void VerifySubtractionOfNegativeNumbers()
        {
            var expectedResult = -2;
            var firstNumber = -4; 
            var secondNumber = -2; 

            var resultOfSubstract = new Substract(firstNumber, secondNumber).Perform();

            Assert.AreEqual(expectedResult, resultOfSubstract, $"The Expected result of Substract should be {expectedResult} But it was: {resultOfSubstract}");
        }

        [TestMethod]
        public void VerifyUndoOfSubtractionOfPositiveNumbers()
        {
            var expectedResult = 6;
            var expectedUndo = 8;
            var firstNumber = 8;
            var secondNumber = 2;

            var substractToTest = new Substract(firstNumber, secondNumber);
            var resultOfSubstract = substractToTest.Perform();
            var resultOfUndo = substractToTest.Undo();

            Assert.AreEqual(expectedResult, resultOfSubstract, $"The Expected result of Substract should be {expectedResult} But it was: {resultOfSubstract}");
            Assert.AreEqual(expectedUndo, resultOfUndo, $"The Expected result of Undo in Substract should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }
}
