using CalculatorModel.CalculatorExceptions;

namespace CalculatorModel
{
    public class OneArgumentsOperation : IOperation
    {
       private readonly Func<double, double> AimFunc;

        public OneArgumentsOperation(Func<double, double> aimFunc)
        {
            AimFunc = aimFunc;
        }

        public double Call(double[] args)
        {
            if (args.Length != 1)
                throw new CalculatorInvalidArgumentsAmountException("This operation needs one argument.");
            return AimFunc(args[0]);
        }
    }
}
