using CalculadoraDemo.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CalculadoraDemo.DataDrive
{
    [TestClass]
    public class DataDriveDivide
    {
        public static IEnumerable<object[]> AdditionData
        {
            get
            {
                return OperationDivision.GetDivisionData();
            }
        }

        [TestMethod]
        [DynamicData(nameof(AdditionData))]
        public void VerifyDivisionOfTwoIntegerNumber(int firstNumber, int secondNumber, int expectedDivision)
        {

            var resultOfDivision = new Division(firstNumber, secondNumber).Perform();
            Assert.AreEqual(expectedDivision, resultOfDivision, $"The Expected result of Multication Test should be {expectedDivision} But it was: {resultOfDivision}");
        }
    }
}
