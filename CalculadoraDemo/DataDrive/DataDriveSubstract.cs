using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDemo.DataDrive
{
    [TestClass]
    public class DataDriveSubstract
    {
        public static IEnumerable<object[]> AdditionData
        {
            get
            {
                return new[]
                {
                    new object[] {8, 3, 5},
                    new object[] {-6, -3, -9 },
                    new object[] {-7, 2, -9 },
                    new object[] {9, -4, 5},
                    new object[] {0, 6, -6},
                    new object[] {4, 0, 4},
                    new object[] {-5, 0, -5},
                    new object[] {0, -3, -0},
                    new object[] {0, 0, 0},

                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(AdditionData))]

        public void VerifySubstractOfTwoIntegerNumber(int firstNumber, int secondNumber, int expectedSubstract)
        {

            var resultOfSubstract = new Substract(firstNumber, secondNumber).Perform();
            Assert.AreEqual(expectedSubstract, resultOfSubstract, $"The Expected result of Substract Test should be {expectedSubstract} But it was: {resultOfSubstract}");

        }
    }
}
