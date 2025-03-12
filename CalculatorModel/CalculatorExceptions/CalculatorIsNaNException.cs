namespace CalculatorModel.CalculatorExceptions
{
    public class CalculatorIsNaNException : CalculatorException
    {
        public CalculatorIsNaNException()
        {

        }

        public CalculatorIsNaNException(string message)
            : base(message)
        {

        }

        public CalculatorIsNaNException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}
