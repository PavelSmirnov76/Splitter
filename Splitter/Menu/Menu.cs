using SortingAlgorithmsConsoleView.Services.ReaderService;

namespace SortingAlgorithmsConsoleView.Menu
{
    public enum SortOptions
    {
        Bubble = 1,
        Quick = 2
    }
    public class Menu
    {
        private readonly MenuWriterHelper menuWriterHelper;
        private readonly IReaderService readerService;


        public Menu(MenuWriterHelper menuWriterHelper, IReaderService readerService )
        {
            this.readerService = readerService;
            this.menuWriterHelper = menuWriterHelper;
        }
        public void OpenMenu()
        {
            do
            {
                try
                {
                    menuWriterHelper.WriteChoiseStringMenu();
                    var str = ChoiseString();

                    menuWriterHelper.WriteChoiseSeparatorMenu();
                    var separator = ChoiseString();

                    if(separator.Length != 1)
                    {
                        throw new ArgumentException("Неверно введен разделитель.");
                    }
                    var arrayString = Splitter.Splitter.Split(str, separator[0]);
                    menuWriterHelper.WriteSortedArray(arrayString);
                }
                catch (Exception ex)
                {
                    menuWriterHelper.WriteException(ex.Message);
                }
            }
            while (true);
        }

        private string ChoiseString()
        {
            return readerService.ReadLine();
        }
    }
}
