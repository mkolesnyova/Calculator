using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorModel;
using CalculatorModel.CalculatorExceptions;

namespace ConsoleCalculator
{
    public class ConsoleController
    {
        private readonly Calculator _model;
        private readonly ConsoleView _view;

        public ConsoleController(Calculator model, ConsoleView view)
        {
            _model = model;
            _view = view;
        }

        public void Run()
        {
            try
            {
                string operation = _view.GetOperation();
                string args = _view.GetArguments();

                double result = _model.Calculate(operation, args);
                _view.ShowResult(result);

            }
            catch (CalculatorException ex)
            {
                _view.ShowError(ex.Message);
            }

            string choice = _view.ShowMenu();

            if (choice.Length < 1) Run();                        

        }

    }
}
