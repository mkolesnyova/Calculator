using CalculatorModel.CalculatorExceptions;

namespace CalculatorModel
{
    public class ZeroArgumentsOperation : IOperation
    {
        private readonly Func<double> AimFunc;

        public ZeroArgumentsOperation(Func<double> aimFunc)
        {
            AimFunc = aimFunc;
        }

        public double Call(params double[] args)
        {
            if (args.Length != 0)
                throw new CalculatorException("This operation doesn't need any arguments.");
            return AimFunc();
        }
    }
}

