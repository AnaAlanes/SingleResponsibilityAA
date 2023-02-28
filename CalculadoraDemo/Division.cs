namespace CalculadoraDemo
{
    public class Division
    {
        public int firstNumber;
        public int secondNumber;
        public int resultDivision;

        public Division(int firstNumber, int secondNumber)
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
