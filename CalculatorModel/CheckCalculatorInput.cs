using CalculatorModel.CalculatorExceptions;

namespace CalculatorModel
{
    public static class CheckCalculatorInput
    {   
        public static string CheckInputOperation(this string inputValue)
        {
            Calculator calculator = new();

            if (inputValue.Length < 1)
                throw new CalculatorInvalidInputException("There is no operation enteries.");

            if (!calculator.ContainsOperation(inputValue))
                throw new CalculatorInvalidInputException($"Unknown operation: {inputValue}");

            return inputValue;

        }
    }
}
