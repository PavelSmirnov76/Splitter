using Splitter;
using System.ComponentModel.DataAnnotations;

namespace Splitter
{
    public class Program
    {

        
        static void Main()
        {
            Console.WriteLine("Введите строку");

            var str = Console.ReadLine();

            Console.WriteLine("Введите сепаратор");
            var separator = Console.ReadLine()[0];

            foreach (var item in Splitter.TestSplit(str, separator))
            {
                Console.WriteLine(item);
            }
        }
    }
}