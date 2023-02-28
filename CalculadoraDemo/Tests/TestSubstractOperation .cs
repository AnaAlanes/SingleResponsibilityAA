using CalculadoraDemo.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CalculadoraDemo.tests
{
    public class TestSubstractOperation
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
        public void VerifySubstractOfTwoIntegerNumbers(int id, string firstNumber, string secondNumber, string expectedSubstract)
        {
            var resultOfSubstract = new Substract(int.Parse(firstNumber), int.Parse(secondNumber)).Perform();
            Assert.AreEqual(int.Parse(expectedSubstract), resultOfSubstract, $"The Expected result of Substract should be {expectedSubstract} But it was: {resultOfSubstract}");
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
