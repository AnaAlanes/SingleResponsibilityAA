using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDemo.DataDrive
{
    [TestClass] 
    internal class DataDriveMultiplication
    {
        public static IEnumerable<object[]> AdditionData
        {
            get
            {
                return new[]
                {
                    new object[] {10, 4, 40},
                    new object[] {-6, -4, -2},
                    new object[] {-3, 8, -24},
                    new object[] {5, -4, 1},
                    new object[] {0, 8, 0},
                    new object[] {6, 0, 0},
                    new object[] {-7, 0, 0},
                    new object[] {0, -9, -9},
                    new object[] {0, 0, 0},

                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(AdditionData))]

        public void VerifyMulticationOfTwoIntegerNumber(int firstNumber, int secondNumber, int expectedMultication)
        {

            var resultOfMultication = new Multiply(firstNumber, secondNumber).Perform();
            Assert.AreEqual(expectedMultication, resultOfMultication, $"The Expected result of SumTest should be {expectedMultication} But it was: {resultOfMultication}");
        }
    }
}
