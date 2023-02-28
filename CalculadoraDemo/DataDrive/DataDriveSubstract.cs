using CalculadoraDemo.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CalculadoraDemo.DataDrive
{
    [TestClass]
    public class DataDriveSubstract
    {
        public static IEnumerable<object[]> AdditionData
        {
            get
            {
                return OperationSubstract.GetSubstractData();
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
