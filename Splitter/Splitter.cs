namespace Splitter
{
    public class Splitter
    {
        // Данный вариант ближе к заданию, так-как в задании сказано найти ВСЕ вхождения символа разделителя и только потом выбрать строки.
        // или я чего-то не понял(( будет интересно обсудить задачу на собеседовании.
        public static string[] Split(string str, char separator)
        {
            var (separatorsIndex, separatorsCount) = FindSeparatorsIndex(str, separator);

            var strings = new string[separatorsCount];
            var startIndex = 0;

            for (int i = 0; i < separatorsCount; i++)
            {
                strings[i] = str.Substring(startIndex, separatorsIndex[i] - startIndex);
                startIndex = separatorsIndex[i] + 1;
            }

            return strings;
        }

        private static (int[], int) FindSeparatorsIndex(string str, char separator)
        {
            var separatorsIndex = new int[str.Length];
            var countSeparators = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (separator == str[i])
                {
                    separatorsIndex[countSeparators] = i;

                    countSeparators++;
                }
                else if (str.Length == i + 1)
                {
                    separatorsIndex[countSeparators] = i + 1;
                    countSeparators++;
                }
            }

            return (separatorsIndex, countSeparators);
        }
        // ищем количество в строке что-бы определить размер массива.
        // проходим по строке еще раз что-бы раздлеить (нет конкатенации строк)
        public static string[] TestSplit(string str, char separator)
        {
            var strings = new string[FindSize(str, separator) + 1];
            var index = 0;
            var startIndex = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == separator)
                {
                    strings[index++] = (str.Substring(startIndex, i - startIndex));
                    startIndex = i + 1;
                }
                else if(str.Length == i + 1)
                {
                    strings[index++] = (str.Substring(startIndex, i - startIndex + 1));
                    startIndex = i + 1;
                }
            }

            return strings;
        }

        private static int FindSize(string str, char separator)
        {
            return str.Count(c => c == separator);
        }
        // 
        // 1. для листа строк выделяется непонятно сколько места
        // 2. в конце идет перезапись строк.
        public static string[] BadSplit(string str, char separator)
        {
            var listString = new List<string>();
            var startIndex = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == separator || str.Length == i + 1)
                {
                    listString.Add(str.Substring(startIndex, i - startIndex));
                    startIndex = i + 1;
                }
            }

            return listString.ToArray();

        }
    }
}
