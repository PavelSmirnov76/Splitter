using SortingAlgorithmsConsoleView.Menu;
using SortingAlgorithmsConsoleView.Services.PrinterService;
using SortingAlgorithmsConsoleView.Services.ReaderService;
using Splitter;
using System.ComponentModel.DataAnnotations;

namespace Splitter
{
    public class Program
    {

        
        static void Main()
        {
            var menu = new Menu(new MenuWriterHelper(new ConsolePrinterService()), new ConsoleReaderService());

            menu.OpenMenu();
        }
    }
}