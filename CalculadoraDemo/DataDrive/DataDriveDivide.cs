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
                return new[]
                {
                    new object[] {10, 2, 5},
                    new object[] {-6, -4, 1},
                    new object[] {-8, 3, -2},
                    new object[] {6, -4, -1},

                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(AdditionData))]
        public void VerifyDivisionOfTwoIntegerNumber(int firstNumber, int secondNumber, int expectedDivision)
        {

            var resultOfDivision = new Divide(firstNumber, secondNumber).Perform();
            Assert.AreEqual(expectedDivision, resultOfDivision, $"The Expected result of Multication Test should be {expectedDivision} But it was: {resultOfDivision}");
        }
    }
}
