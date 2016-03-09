
namespace CsvViewer.Tests
{
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
        public void Output_Should_Be_Splitted_with_One_Line_Of_Input()
        {
            var input = "abc;def;ghi";
            var reader = new CsvReader(input);

            reader.Read().Should().BeTrue();

            reader.GetCurrent().Should().BeEquivalentTo("abc", "def", "ghi");
        }
    }
}
