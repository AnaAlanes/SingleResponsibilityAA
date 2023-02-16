using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CalculadoraDemo.DataDrive
{
    [TestClass] 
    public class DataDriveMultiplication
    {
        public static IEnumerable<object[]> AdditionData
        {
            get
            {
                return new[]
                {
                    new object[] {10, 4, 40},
                    new object[] {-6, -4, 24},
                    new object[] {-3, 8, -24},
                    new object[] {8, -2, -16},
                    new object[] {0, 8, 0},
                    new object[] {6, 0, 0},
                    new object[] {-7, 0, 0},
                    new object[] {0, -9, 0},
                    new object[] {0, 0, 0},

                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(AdditionData))]

        public void VerifyMulticationOfTwoIntegerNumber(int firstNumber, int secondNumber, int expectedMultication)
        {

            var resultOfMultication = new Multiply(firstNumber, secondNumber).Perform();
            Assert.AreEqual(expectedMultication, resultOfMultication, $"The Expected result of Multication Test should be {expectedMultication} But it was: {resultOfMultication}");
        }
    }
}
