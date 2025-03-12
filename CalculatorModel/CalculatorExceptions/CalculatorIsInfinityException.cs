namespace CalculatorModel.CalculatorExceptions
{
    public class CalculatorIsInfinityException : CalculatorException
    {
        public CalculatorIsInfinityException()
        {

        }

        public CalculatorIsInfinityException(string message)
            : base(message)
        {

        }

        public CalculatorIsInfinityException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}
