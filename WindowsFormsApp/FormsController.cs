using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorModel;

namespace GraphicalCalculator
{
    public class FormsController
    {
        private readonly FormsView _view;
        private readonly Calculator _model;

        public FormsController(Calculator model, FormsView view)
        {
            _view = view;
            _model = model;

            _view.ArgumentsPressed += OnArgumentsClick;
            _view.ResultPressed += OnResultClick;
        }

        public void OnArgumentsClick(string args)
        {
            _view.Arguments = args;
        }

        public void OnResultClick(string _)
        {

            string op = _view.Operation;
            string args = _view.Arguments;

            try
            {

                double result = _model.Calculate(op, args);
                _view.DisplayResult(result);

            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }

        }

    }
}
