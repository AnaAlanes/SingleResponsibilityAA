namespace CalculadoraDemo
{
    public class Divide
    {
        public int firstNumber;
        public int secondNumber;
        public int resultDivision;

        public Divide(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public int Perform()
        {
            resultDivision = (firstNumber / secondNumber);
            return resultDivision;
        }
        public int Undo()
        {
            return resultDivision * secondNumber;
        }
    }
}
