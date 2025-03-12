namespace CalculatorModel.CalculatorExceptions
{
    public class CalculatorNegativeNumberException : CalculatorException
    {
        public CalculatorNegativeNumberException()
        {

        }

        public CalculatorNegativeNumberException(string message)
            : base(message)
        {

        }

        public CalculatorNegativeNumberException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}
