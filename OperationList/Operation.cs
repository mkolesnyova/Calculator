namespace CalculatorModel
{
    sealed class Operation : IOperation
    {

        private Func<double[], double> AimFunc;
        //private int ArgsNumber;

        public Operation(Func<double[], double> aimFunc/*, int argsNumber*/)
        {
            //ArgsNumber = argsNumber;
            AimFunc = aimFunc;
        }

        public double Call(params double[] args)
        {
            return AimFunc(args);
        }
    }
}
