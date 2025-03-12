using CalculatorModel.CalculatorExceptions;

namespace CalculatorModel
{
    public static class CheckCalculatorOutput
    {

        public static double CheckOutput(this double outputValue)
        {           

            if (double.IsInfinity(outputValue))
                throw new CalculatorIsInfinityException("Incorrect input of arguments.");

            if (double.IsNaN(outputValue))
                throw new CalculatorIsNaNException("Incorrect input of arguments.");

            return outputValue;

        }

    }
}
