using CalculadoraDemo.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CalculadoraDemo.Tests
{
    [TestClass]
    public class TestMultiplicationOperation
    {

        public static IEnumerable<object[]> MultiplicationData
        {
            get
            {
                return OperationMultiplication.GetMultiplicationData();
            }
        }

        [TestMethod]
        [DynamicData(nameof(MultiplicationData))]
        public void VerifyMultiplicationOfTwoIntegerNumbers(int id, string firstNumber, string secondNumber, string expectedMultiplication, string expectedUndo)
        {
            var resultOfMultiplication = new Multiply(int.Parse(firstNumber), int.Parse(secondNumber)).Perform();
            Assert.AreEqual(int.Parse(expectedMultiplication), resultOfMultiplication, $"The Expected result of Multiplication should be {expectedMultiplication} But it was: {resultOfMultiplication}");
        }

        [TestMethod]
        [DynamicData(nameof(MultiplicationData))]
        public void VerifyUndoOfAMultiplyOfPositiveNumbers(int id, string firstNumber, string secondNumber, string expectedMultiplication, string expectedUndo)
        {
            var Multiplication = new Multiply(int.Parse(firstNumber), int.Parse(secondNumber));
            var resultOfMultiplication = Multiplication.Perform();
            var resultOfUndo = Multiplication.Undo();

            Assert.AreEqual(int.Parse(expectedMultiplication), resultOfMultiplication, $"The Expected result of Multiplication should be {expectedMultiplication} But it was: {resultOfMultiplication}");
            Assert.AreEqual(int.Parse(expectedUndo), resultOfUndo, $"The Expected result of Undo in Multiplication should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }
}
