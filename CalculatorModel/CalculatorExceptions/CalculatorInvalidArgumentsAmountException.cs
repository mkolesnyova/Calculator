using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorModel.CalculatorExceptions
{
    public class CalculatorInvalidArgumentsAmountException : CalculatorException 
    {
        public CalculatorInvalidArgumentsAmountException() 
        {
        
        }

        public CalculatorInvalidArgumentsAmountException(string message)
            : base(message) 
        {
        
        }

        public CalculatorInvalidArgumentsAmountException(string message, Exception inner) 
            : base(message, inner)
        {

        }
    }
}
