using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CalculadoraDemo.tests
{
    [TestClass]
    public class OperationTestsSum
    {
   
        [TestMethod]
        public void VerifySumOfPositiveNumbers()
        {
            var expectedSum = 3; 
            var firstNumber = 1;    
            var secondNumber = 2;   

            var resultOfSum = new Sum(firstNumber, secondNumber).Perform();

            Assert.AreEqual(expectedSum, resultOfSum, $"The Expected result of Sum should be {expectedSum} But it was: {resultOfSum}");  
        }

        [TestMethod]
        public void VerifySumOfNegativeNumbers()
        {
            var expectedSum = -3;
            var firstNumber = -1;
            var secondNumber = -2;

            var resultOfSum = new Sum(firstNumber, secondNumber).Perform();

            Assert.AreEqual(expectedSum, resultOfSum, $"The Expected result of Sum should be {expectedSum} But it was: {resultOfSum}");
        }

        [TestMethod]
        public void VerifyUndoOfSumOfPositiveNumbers()
        {
            var expectedSum = 3;
            var firstNumber = 1;
            var expectedUndo = 1;
            var secondNumber = 2;

            var sumToTest = new Sum(firstNumber, secondNumber);
            var resultOfSum = sumToTest.Perform();  
            var resultOfUndo = sumToTest.Undo();

            Assert.AreEqual(expectedSum, resultOfSum, $"The Expected result of Sum should be {expectedSum} But it was: {resultOfSum}");
            Assert.AreEqual(expectedUndo, resultOfUndo, $"The Expected result of Undo in Sum should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }
}
