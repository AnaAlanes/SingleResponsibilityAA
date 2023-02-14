using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDemo.tests
{
    [TestClass]
    public class OperationTests
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
            var expectedSubstract = -6;
            var firstNumber = -4;
            var secondNumber = -2;

            var resultOfSubstract = new Substract(firstNumber, secondNumber).Perform();

            Assert.AreEqual(expectedSubstract, resultOfSubstract, $"The Expected result of Substract should be {expectedSubstract} But it was: {resultOfSubstract}");
        }

        [TestMethod]
        public void VerifyUndoOfSubstractOfPositiveNumbers()
        {
            var expectedSubstract = 6;
            var expectedUndo = 1;
            var firstNumber = 8;
            var secondNumber =2;

            var substractToTest = new Substract(firstNumber, secondNumber);
            var resultOfSubstract = substractToTest.Perform();
            var resultOfUndo = substractToTest.Undo();

            Assert.AreEqual(expectedSubstract, resultOfSubstract, $"The Expected result of Substract should be {expectedSubstract} But it was: {resultOfSubstract}");
            Assert.AreEqual(expectedUndo, resultOfUndo, $"The Expected result of Undo in Substract should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }
}
