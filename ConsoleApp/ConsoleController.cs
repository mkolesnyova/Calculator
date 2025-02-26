using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperationList;

namespace ConsoleApp
{
    public class ConsoleController
    {
        private readonly OperationLibrary _model;
        private readonly ConsoleView _view;

        public ConsoleController(OperationLibrary model, ConsoleView view)
        {
            _model = model;
            _view = view;
        }

        public void Run()
        {
            try
            {
                string operation = _view.GetOperation();
                double[] args = _view.GetArguments(operation);

                double result = _model.Calculate(operation, args);
                _view.ShowResult(result);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

    }
}
