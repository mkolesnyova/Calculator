using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ConsoleView
    {
        public string GetOperation()
        {
            Console.Write("Op: ");
            return Console.ReadLine();
        }

        public double[] GetArguments(string operation)
        {
            if (operation == "pi" || operation == "e") return new double[0];

            Console.Write("Args: ");
            string[] inputArgs = Console.ReadLine().Split(' ');

            return Array.ConvertAll(inputArgs, double.Parse);
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
