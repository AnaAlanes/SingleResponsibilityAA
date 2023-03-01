using CalculadoraDemo.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CalculadoraDemo.Tests
{
    [TestClass]
    public class TestDivisionOperation
    {
        public static IEnumerable<object[]> DivisionData
        {
            get
            {
                return OperationDivision.GetDivisionData();
            }
        }

        [TestMethod]
        [DynamicData(nameof(DivisionData))]
        public void VerifyDivisionOfTwoIntegerNumbers(int ID, string firstNumber, string secondNumber, string expectedDivision, string expectedUndo)
        {
            var resultOfDivision = new Division(int.Parse(firstNumber), int.Parse(secondNumber)).Perform();
            Assert.AreEqual(int.Parse(expectedDivision), resultOfDivision, $"The Expected result of Division should be {expectedDivision} But it was: {resultOfDivision}");
        }

        [TestMethod]
        [DynamicData(nameof(DivisionData))]
        public void VerifyUndoOfADivisionOfPositiveNumbers(int ID, string firstNumber, string secondNumber, string expectedDivision, string expectedUndo)
        {
            var Division = new Division(int.Parse(firstNumber), int.Parse(secondNumber));

            var resultOfDivision = Division.Perform();
            var resultOfUndo = Division.Undo();

            Assert.AreEqual(int.Parse(expectedDivision), resultOfDivision, $"The Expected result of Division should be {expectedDivision} But it was: {resultOfDivision}");
            Assert.AreEqual(int.Parse(expectedUndo), resultOfUndo, $"The Expected result of Undo in Division should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }
}
