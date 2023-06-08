namespace SortingAlgorithmsConsoleView.Services.ReaderService
{
    public class ConsoleReaderService: IReaderService
    {
        public string ReadLine()
        {
            return Console.ReadLine() ?? throw new ArgumentNullException();
        }
    }
}
