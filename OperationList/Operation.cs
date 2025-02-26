using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationList
{
    public class Operation : IOperation
    {

        Func<double[], double> AimFunc;

        public Operation(Func<double[], double> aimFunc)
        {
            AimFunc = aimFunc;
        }

        public double Call(params double[] args)
        {
            return AimFunc(args);
        }
    }
}
