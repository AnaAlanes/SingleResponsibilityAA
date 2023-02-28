using CalculadoraDemo.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CalculadoraDemo.tests
{
    [TestClass]
    public class TestSumOperation
    {
        public static IEnumerable<object[]> AdditionData
        {
            get
            {
                return OperationHelper.GetAdditionData();
            }
        }

        [TestMethod]
        [DynamicData(nameof(AdditionData))]
        public void VerifySumOfTwoIntegerNumbers(int id, string firstNumber, string secondNumber, string expectedSum)
        {
            var resultOfSum = new Sum(int.Parse(firstNumber), int.Parse(secondNumber)).Perform();
            Assert.AreEqual(int.Parse(expectedSum), resultOfSum, $"The Expected result of Sum should be {expectedSum} But it was: {resultOfSum}");
        }


        [TestMethod]
        public void VerifyUndoOfSumOfPositiveNumbers()
        {
            var expectedResult = 3;
            var firstNumber = 1;
            var expectedUndo = 1;
            var secondNumber = 2;

            var sumToTest = new Sum(firstNumber, secondNumber);
            var resultOfSum = sumToTest.Perform();  
            var resultOfUndo = sumToTest.Undo();

            Assert.AreEqual(expectedResult, resultOfSum, $"The Expected result of Sum should be {expectedResult} But it was: {resultOfSum}");
            Assert.AreEqual(expectedUndo, resultOfUndo, $"The Expected result of Undo in Sum should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }
}
