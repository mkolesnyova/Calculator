using CalculatorModel.CalculatorExceptions;

namespace CalculatorModel
{
    public class Calculator
    {
        private readonly SetCalculatorOperation setOperation;
        public Calculator()
        {
            setOperation = new()
            {
                {"+", (a, b) => a + b },
                {"-", (a, b) => a - b },
                {"*", (a, b) => a * b },
                {"/", (a, b) => a / b },
                { "sin", (a) => Math.Sin(a)},
                {"cos", (a) => Math.Cos(a) },
                {"tan", (a) => Math.Tan(a) },
                {"asin", (a) => Math.Asin(a) },
                {"acos", (a) => Math.Acos(a) },
                {"atan", (a) => Math.Atan(a) },
                {"atan2", (a, b) => Math.Atan2(a, b) },
                {"sqrt", (a) => Math.Sqrt(a) },
                {"log", (a) => Math.Log(a) },
                {"log10", (a) => Math.Log10(a) },
                {"pow", (a, b) => Math.Pow(a, b) },
                {"abs", (a) => Math.Abs(a) },
                {"pi", () => Math.PI },
                {"e", () => Math.E }
            };

            AddNewOperation();

        }

        public bool ContainsOperation(string op) => setOperation.ContainsOperation(op);

        public void AddNewOperation()
        {

            SetCalculatorOperation setOperation = new()
            {
                {"cbrt", (a) => Math.Cbrt(a) },
                {"mult2", (a) => a * 2 }
            };

            foreach (var op in setOperation)
            {
                setOperation.Operations[op.Key] = op.Value;
            }
        }

        public double Calculate(string operation, string arguments)
        {
            try
            {
                operation.CheckInputOperation();

                double[] args = ParseArguments(arguments);
                
                double result = setOperation.Operations[operation].Call(args);

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