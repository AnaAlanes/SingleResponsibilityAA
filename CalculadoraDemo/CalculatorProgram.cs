using System;

namespace CalculadoraDemo
{
    public class CalculatorProgram
    {
        public int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int Substract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public float Divide(int firstNumber, int secondNumber)
        {
            return (float)firstNumber / (float)secondNumber;
        }

        static void Main(string[] args)
        {
            var calculatorProgram = new CalculatorProgram();

            var firstSum = new Sum(1, 2);
            var secondSum = new Sum(firstSum.Perform(), 8);
            var sumThird = new Sum(secondSum.Perform(), 9);
            Console.WriteLine(sumThird.Perform());
            var resultAfterUndo = sumThird.Undo();

            Console.WriteLine("----------Sum--------------");
            Console.WriteLine(resultAfterUndo);
            Console.WriteLine("------------------------");

            Console.WriteLine("-----------Substract-------------");
            var firstSubstract = new Substract(10, 2);
            var secondSubstract = new Substract(firstSubstract.Perform(), 2);
            Console.WriteLine(secondSubstract.Perform());

            Console.WriteLine("-----------Multiply-------------");
            var firstMultiplication = new Multiply(6, 2);
            var secondMultiplication = new Multiply(firstMultiplication.Perform(), 2);
            Console.WriteLine(secondMultiplication.Perform());

            Console.WriteLine("-----------Divide-------------");
            var firstDivide = new Multiply(6, 2);
            var secondDivide = new Multiply(firstDivide.Perform(), 2);
            Console.WriteLine(secondDivide.Perform());
            Console.WriteLine("");


            var respSum = calculatorProgram.Sum(1, 2);
            respSum = calculatorProgram.Sum(respSum, 8);
            respSum = calculatorProgram.Sum(respSum, 9);

            var respSubstract = calculatorProgram.Substract(4, 2);
            var respMultiply = calculatorProgram.Multiply(3, 7);
            var respDivide = calculatorProgram.Divide(3, 2);
        }
    }
}
