using CalculadoraDemo.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CalculadoraDemo.tests
{
    public class TestMultiplicationOperation
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
        public void VerifyMultiplicationOfTwoIntegerNumbers(int id, string firstNumber, string secondNumber, string expectedMultiplication)
        {
            var resultOfMultiplication = new Multiply(int.Parse(firstNumber), int.Parse(secondNumber)).Perform();
            Assert.AreEqual(int.Parse(expectedMultiplication), resultOfMultiplication, $"The Expected result of Multiplication should be {expectedMultiplication} But it was: {resultOfMultiplication}");
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

            Assert.AreEqual(expectedResult, resultOfmultication, $"The Expected result of Multiplication should be {expectedResult} But it was: {resultOfmultication}");
            Assert.AreEqual(expectedUndo, resultOfUndo, $"The Expected result of Undo in Multiplication should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }
}
