namespace CalculatorModel.CalculatorExceptions
{
    public class CalculatorInvalidInputException : CalculatorException
    {
        public CalculatorInvalidInputException()
        {

        }

        public CalculatorInvalidInputException(string message)
            : base(message)
        {

        }

        public CalculatorInvalidInputException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}
