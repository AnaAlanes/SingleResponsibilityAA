using CalculadoraDemo.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CalculadoraDemo.tests
{
    public class TestDivisionOperation
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
        public void VerifyDivisionOfTwoIntegerNumbers(int id, string firstNumber, string secondNumber, string expectedDivision)
        {
            var resultOfDivision = new Division(int.Parse(firstNumber), int.Parse(secondNumber)).Perform();
            Assert.AreEqual(int.Parse(expectedDivision), resultOfDivision, $"The Expected result of Division should be {expectedDivision} But it was: {resultOfDivision}");
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

            Assert.AreEqual(expectedResult, resultOfDivision, $"The Expected result of Division should be {expectedResult} But it was: {resultOfDivision}");
            Assert.AreEqual(expectedUndo, resultOfUndo, $"The Expected result of Undo in Division should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }
}
