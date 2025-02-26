using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationList
{
    public interface IOperation
    {
        double Call(params double[] args);
    }

}
