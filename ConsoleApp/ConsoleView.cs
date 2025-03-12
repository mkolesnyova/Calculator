using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class ConsoleView
    {
        public string ShowMenu()
        {
            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine("Press Enter to continue or any button to end calculation");
            Console.Write("------------------------------------>> >> ");
            return Console.ReadLine();
        }
               

        public string GetOperation()
        {
            Console.Write("\nOp: ");           
            return Console.ReadLine();
        }

        public string GetArguments()
        {
            Console.Write("Args: ");
            return Console.ReadLine();
        }

        public void ShowResult(double result)
        {
            Console.WriteLine($"Res: {result}");
        }

        public void ShowError(string message)
        {
            Console.WriteLine($"{message}");
        }

    }
}
