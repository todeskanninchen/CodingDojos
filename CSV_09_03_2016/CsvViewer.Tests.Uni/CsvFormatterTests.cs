
namespace CsvViewer.Tests
{
    using CsvViewer;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CsvFormatterTests
    {
        [TestMethod]
        public void CanCreate()
        {
            var formatter = new CsvFormatter();
            Assert.IsTrue(formatter != null);
        }
    }
}
