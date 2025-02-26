using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationList
{
    public class OperationLibrary
    {
        public Dictionary<string, IOperation> operations { get; set; }

        public OperationLibrary()
        {
            operations = new Dictionary<string, IOperation>(StringComparer.OrdinalIgnoreCase)
            {
                {"+", new Operation(args => args[0]+args[1]) },
                {"-", new Operation(args => args[0]-args[1]) },
                {"*", new Operation(args => args[0]*args[1]) },
                {"/", new Operation(args => args[0] / args[1]) },
                { "sin", new Operation(args => Math.Sin(args[0])) },
                {"cos", new Operation(args => Math.Cos(args[0])) },
                {"tan", new Operation(args => Math.Tan(args[0])) },
                {"asin", new Operation(args => Math.Asin(args[0])) },
                {"acos", new Operation(args => Math.Acos(args[0])) },
                {"atan", new Operation(args => Math.Atan(args[0])) },
                {"atan2", new Operation(args => Math.Atan2(args[0], args[1])) },
                {"sqrt", new Operation(args => Math.Sqrt(args[0])) },
                {"log", new Operation(args => Math.Log(args[0])) },
                {"log10", new Operation(args => Math.Log10(args[0])) },
                {"pow", new Operation(args => Math.Pow(args[0], args[1])) },
                {"abs", new Operation(args => Math.Abs(args[0])) },
                {"pi", new Operation(args => Math.PI)},
                {"e", new Operation(args => Math.E) }
            };
            AddNewOperation();

        }

        public void AddNewOperation()
        {
            var dict = new Dictionary<string, IOperation>
            {
                {"cbrt", new Operation(args => Math.Cbrt(args[0])) },
                {"mult2", new Operation(args => args[0]*2) }
            };

            foreach (var op in dict)
            {
                operations[op.Key] = op.Value;
            }

        }

        public bool ContainsOperation(string op) => operations.ContainsKey(op);

        public double Calculate(string operation, double[] args)
        {
            if (!operations.TryGetValue(operation, out var op))
                throw new InvalidOperationException($"Unknown operation: {operation}");

            try
            {
                double result = op.Call(args);

                if (double.IsNaN(result))
                    throw new ArithmeticException("Calculation resulted in an invalid number (NaN).");

                if (double.IsInfinity(result))
                    throw new ArithmeticException("Calculation resulted in an infinite number.");

                return result;
            }
            catch (Exception ex) when (
                ex is DivideByZeroException ||
                ex is ArgumentOutOfRangeException ||
                ex is OverflowException ||
                ex is ArithmeticException)
            {
                throw new InvalidOperationException($"Calculation error: {ex.Message}", ex);
            }
        }

    }
}
