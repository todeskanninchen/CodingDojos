namespace CsvViewer.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using FluentAssertions;

    [TestClass]
    public class CsvFormatterTests
    {
        [TestMethod]
        public void CanCreate()
        {
            var formatter = new CsvFormatter();
            formatter.Should().NotBeNull();
        }
    }
}
