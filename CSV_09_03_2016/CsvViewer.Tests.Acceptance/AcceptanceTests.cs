namespace CsvViewer.Tests.Acceptance
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using FluentAssertions;

    [TestClass]
    public class AcceptanceTests
    {
        [TestMethod]
        [DeploymentItem("_TestData/emtpyFile.csv")]
        public void Emtpy_File_Should_Display_Nothing()
        {
            var csvProcessor = new CsvProcessor();
            csvProcessor.Process("emptyFile.csv");

            var result = csvProcessor.GetResult();
            result.Should().BeEmpty();
        }
    }
}
