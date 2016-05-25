namespace CsvViewer
{
    using System.IO;

    public class CsvProcessor
    {
        private string result = string.Empty;
        public void Process(string inputFile)
        {
            string fileContent = File.ReadAllText(inputFile);
            CsvReader reader = new CsvReader(fileContent);
            reader.Read();
            // var headerLineValues = reader.GetCurrent();
            //CsvFormatter formatter = new CsvFormatter();
            //result = formatter.FormatLine(headerLineValues);
        }

        public string GetResult()
        {
            return result;
        }
    }
}