using CalculatorModel;
namespace GraphicalCalculator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Calculator model = new Calculator();
            FormsView view = new FormsView();
            FormsController controller = new FormsController(model, view);

            Application.Run(view);
        }
    }
}