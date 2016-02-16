namespace FizzBuzz.Tests
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FizzBuzzGeneratorTests
    {
        private FizzBuzzConverter _sut;

        [TestInitialize]
        public void Setup()
        {
            _sut = new FizzBuzzConverter();
        }

        [TestMethod]
        public void CanConvertOne()
        {
            Should_Convert_Number_To_ExpectedOutput(1, "1");
        }

        [TestMethod]
        public void CanConvertTwo()
        {
            Should_Convert_Number_To_ExpectedOutput(2, "2");
        }

        [TestMethod]
        public void CanConvertThree()
        {
            Should_Convert_Number_To_ExpectedOutput(3, "Fizz");
        }

        [TestMethod]
        public void CanConvertSix()
        {
            Should_Convert_Number_To_ExpectedOutput(6, "Fizz");
        }

        private void Should_Convert_Number_To_ExpectedOutput(int numberToConvert, string expected)
        {
            string result = _sut.Convert(numberToConvert);

            result.Should().Be(expected);
        }
    }
}
