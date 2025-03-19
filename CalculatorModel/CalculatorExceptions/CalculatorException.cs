﻿namespace CalculatorModel.CalculatorExceptions
{
    public abstract class CalculatorException : Exception
    {
        public CalculatorException()
        {

        }

        public CalculatorException(string message)
            : base(message)
        {

        }

        public CalculatorException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}
