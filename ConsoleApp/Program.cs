using CalculatorModel;

namespace ConsoleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator model = new Calculator();
            ConsoleView view = new ConsoleView();
            ConsoleController controller = new ConsoleController(model, view);
            controller.Run();
        }
    }
}
