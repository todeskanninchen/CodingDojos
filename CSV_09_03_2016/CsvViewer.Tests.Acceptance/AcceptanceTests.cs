namespace CsvViewer.Tests.Acceptance
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using FluentAssertions;

    [TestClass]
    public class AcceptanceTests
    {
        private const string TestFilesDirectory = "_TestData";

        [TestMethod]
        [DeploymentItem(TestFilesDirectory)]
        public void Emtpy_File_Should_Display_Nothing()
        {
            const string emptyFile = "emptyFile.csv";

            var csvProcessor = new CsvProcessor();
            csvProcessor.Process(emptyFile);

            var result = csvProcessor.GetResult();
            result.Should().BeEmpty();
        }

        [TestMethod]
        [Ignore]
        [DeploymentItem(TestFilesDirectory)]
        public void Person_File_Should_Display_Headerline_Correctly()
        {
            var csvProcessor = new CsvProcessor();
            csvProcessor.Process("singleLineFile.csv");

            var result = csvProcessor.GetResult();
            result.Should().Be(
                "|City|Age|Name|"
                + Environment.NewLine
                + "+----+---+----+");
        }


    }
}
