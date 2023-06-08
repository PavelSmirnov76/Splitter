namespace SplitterTests
{
    public class SplitterTests
    {
        [Fact]
        public void Split_string_aa1asd1qweqweq1asdasd_separator_1___array_aa_asd_qweqweq_asdasd()
        {
            var str = "aa1asd1qweqweq1asdasd";
            var separator = '1';
            var expected = new string[] { "aa", "asd", "qweqweq", "asdasd" };

            var actual = Splitter.Splitter.Split(str, separator);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Split_string_aaaaaa_separator_2___array_aaaaaa()
        {
            var str = "aaaaaa";
            var separator = '2';
            var expected = new string[] { "aaaaaa" };

            var actual = Splitter.Splitter.Split(str, separator);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Split_string_aaaaaa_separator_a___array_SixEmptyString()
        {
            var str = "aaaaaa";
            var separator = 'a';
            var expected = new string[] { "",  "", "", "", "", "" };

            var actual = Splitter.Splitter.Split(str, separator);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Split_stringEmpty_separator_a___arrayEmpty()
        {
            var str = "";
            var separator = 'a';
            var expected = new string[] {};

            var actual = Splitter.Splitter.Split(str, separator);

            Assert.Equal(expected, actual);
        }
    }
}