using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OperationList;

namespace WindowsFormsApp
{
    public class FormsController
    {
        private readonly FormsView _view;
        private readonly OperationLibrary _model;

        public FormsController(OperationLibrary model, FormsView view)
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

            double[] argValues;


            if (op != "pi" && op != "e")
            {
                argValues = ParseArguments(args);
            }
            else
            {

                argValues = new double[0];
            }

            try
            {

                if (_model.ContainsOperation(op))
                {
                    double result = _model.Calculate(op, argValues);
                    _view.DisplayResult(result);
                }
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }

        }

        public double[] ParseArguments(string args)
        {
            try
            {

                string[] inputArgs = args.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                return Array.ConvertAll(inputArgs, double.Parse);
            }
            catch
            {
                throw new Exception("Invalid arguments format.");
            }
        }


    }
}
