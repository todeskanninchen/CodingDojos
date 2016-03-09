namespace CsvViewer
{
    public class CsvReader
    {
        private readonly string _fileContent;

        public CsvReader(string fileContent)
        {
            _fileContent = fileContent;
        }

        public bool Read()
        {
            return !string.IsNullOrEmpty(_fileContent);
        }

        public string[] GetCurrent()
        {
            return _fileContent.Split(';');
        }
    }
}