namespace CalculatorModel
{
    public class CalculatorOperations
    {
        public SetCalculatorOperation operations;
        public CalculatorOperations()
        {
            operations = new()
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

        public bool ContainsOperation(string op) => operations.ContainsOperation(op);

        public void AddNewOperation()
        {

            SetCalculatorOperation dict = new()
            {
                {"cbrt", (a) => Math.Cbrt(a) },
                {"mult2", (a) => a * 2 }
            };

            foreach (var op in dict)
            {
                operations.Operations[op.Key] = op.Value;
            }
        }
    }
}
