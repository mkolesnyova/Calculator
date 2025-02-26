using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperationList;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OperationLibrary model = new OperationLibrary();
            ConsoleView view = new ConsoleView();
            ConsoleController controller = new ConsoleController(model, view);
            controller.Run();
        }
    }
}
