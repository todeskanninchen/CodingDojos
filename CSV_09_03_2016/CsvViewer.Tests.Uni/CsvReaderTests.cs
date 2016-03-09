
namespace CsvViewer.Tests
{
    using System;
    using CsvViewer;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CsvReaderTests
    {
        [TestMethod]
        public void Nothing_To_Read_When_Input_Is_Empty()
        {
            var reader = new CsvReader(string.Empty);
            reader.Read().Should().BeFalse();
        }

        [TestMethod]
        public void Reader_read_two_line_input()
        {
            var input = "abc;def;ghi" + Environment.NewLine + "ccc;dddd;eeeeee";
            var reader = new CsvReader(input);

            reader.Read().Should().BeTrue();
            reader.GetCurrent().Should().BeEquivalentTo("abc", "def", "ghi");
            reader.Read().Should().BeTrue();
            reader.GetCurrent().Should().BeEquivalentTo("ccc", "dddd", "eeeeee");
            reader.Read().Should().BeFalse();
        }

    }
}
