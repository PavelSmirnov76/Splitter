using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmsConsoleView.Services.PrinterService
{
    internal class ConsolePrinterService : IPrinterService
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
