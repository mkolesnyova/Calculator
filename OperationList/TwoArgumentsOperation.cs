using CalculatorModel.CalculatorExceptions;

namespace CalculatorModel
{
    public class TwoArgumentsOperation : IOperation
    {
        private readonly Func<double, double, double> AimFunc;

        public TwoArgumentsOperation(Func<double, double, double> aimFunc)
        {
            AimFunc = aimFunc;
        }

        public double Call(params double[] args)
        {
            if (args.Length != 2)
                throw new CalculatorException("This operation needs two arguments.");
            return AimFunc(args[0], args[1]);
        }

    }
}
