using CalculatorModel.CalculatorExceptions;

namespace CalculatorModel
{
    public class Calculator
    {
        readonly CalculatorOperations calcOperations = new();

        public double Calculate(string operation, string arguments)
        {
            try
            {
                operation.CheckInputOperation();

                double[] args = ParseArguments(arguments);
                
                double result = calcOperations.operations.Operations[operation].Call(args);

                return result.CheckOutput();
            }
            catch (CalculatorException ex)
            {
                throw new CalculatorException($"Calculation error. {ex.Message}", ex);
            }

        }

        public double[] ParseArguments(string args)
        {
            try
            {
                string[] inputArgs = args.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                return Array.ConvertAll(inputArgs, double.Parse);
            }
            catch
            {
                throw new CalculatorInvalidInputException("Invalid arguments format.");
            }
        }
    }
}