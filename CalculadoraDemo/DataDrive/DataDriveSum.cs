//using CalculadoraDemo.Utils;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Collections.Generic;

//namespace CalculadoraDemo.DataDrive
//{
//    [TestClass]
//    public class DataDriveSum
//    {
//        public static IEnumerable<object[]> AdditionData
//        {
//            get 
//            {
//                return OperationHelper.GetAdditionData();
//             }  
//        }

//        [TestMethod]
//        [DynamicData(nameof(AdditionData))]

//        public void VerifySumOfTwoIntegerNumber(int firstNumber, int secondNumber, int expectedSum)
//        {

//            var resultOfSum = new Sum(firstNumber, secondNumber).Perform();
//            Assert.AreEqual(expectedSum, resultOfSum, $"The Expected result of SumTest should be {expectedSum} But it was: {resultOfSum}");
//        }

//    }
//}
