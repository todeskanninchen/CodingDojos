namespace CsvViewer
{
    using System;

    public class CsvReader
    {
        private readonly string[] _lines;
        private int _lineIndex;

        public CsvReader(string fileContent)
        {
            _lines = fileContent.Split(new[] { Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);
            _lineIndex = -1;
        }

        public bool Read()
        {
            _lineIndex++;
            return HasMoreLines();
        }

        private bool HasMoreLines()
        {
            return _lineIndex < _lines.Length;
        }

        public string[] GetCurrent()
        {
            return _lines[_lineIndex].Split(';');
        }
    }
}