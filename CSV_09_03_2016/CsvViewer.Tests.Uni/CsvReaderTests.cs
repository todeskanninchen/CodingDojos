
namespace CsvViewer.Tests
{
    using CsvViewer;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CsvReaderTests
    {
        [TestMethod]
        public void Output_Nothing_When_Input_Is_Empty()
        {
            var reader = new CsvReader(string.Empty);
            reader.Read().Should().BeFalse();
        }
    }
}
