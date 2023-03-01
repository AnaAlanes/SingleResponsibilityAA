//using CalculadoraDemo.Utils;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Collections.Generic;

//namespace CalculadoraDemo.DataDrive
//{
//    [TestClass] 
//    public class DataDriveMultiplication
//    {
//        public static IEnumerable<object[]> MultiplicationData
//        {
//            get
//            {
//                return OperationMultiplication.GetMultiplicationData();
//            }
//        }

//        [TestMethod]
//        [DynamicData(nameof(MultiplicationData))]

//        public void VerifyMulticationOfTwoIntegerNumber(int firstNumber, int secondNumber, int expectedMultication)
//        {

//            var resultOfMultication = new Multiply(firstNumber, secondNumber).Perform();
//            Assert.AreEqual(expectedMultication, resultOfMultication, $"The Expected result of Multication Test should be {expectedMultication} But it was: {resultOfMultication}");
//        }
//    }
//}
