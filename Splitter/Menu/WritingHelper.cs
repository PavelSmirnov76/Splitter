using SortingAlgorithmsConsoleView.Services.PrinterService;

namespace SortingAlgorithmsConsoleView.Menu
{
    public class MenuWriterHelper
    {
        private readonly IPrinterService printerService;

        public MenuWriterHelper(IPrinterService printerService)
        {
            this.printerService = printerService;
        }

        public void WriteChoiseStringMenu()
        {
            printerService.Print("Введите строку.");
        }
        public void WriteChoiseSeparatorMenu()
        {
            printerService.Print("введите разделитель. (1 символ)");
        }

        public void WriteSortedArray(string[] array)
        {
            printerService.Print("Массив слов.");

            foreach (var str in array)
            {
                printerService.Print(str);
            }
        }

        public void WriteException(string message)
        {
            printerService.Print(message);
        }
    }
}
