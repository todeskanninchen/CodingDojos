namespace FizzBuzz.Tests
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FizzBuzzerTests
    {
        private FizzBuzzer _fizzBuzzer;

        [TestInitialize]
        public void Setup()
        {
            _fizzBuzzer = new FizzBuzzer();
        }
        
        [TestMethod]
        public void FizzBuzzInterval_from_1_to_1_should_return_1()
        {
            var result = _fizzBuzzer.FizzBuzzInterval(1, 1);
            result.Should().BeEquivalentTo("1");
        }

        [TestMethod]
        public void FizzBuzzFrom1To16()
        {
            var result = _fizzBuzzer.FizzBuzzInterval(1, 16);
            result.Should().BeEquivalentTo("1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz", "16");
        }

        [TestMethod]
        public void FizzBuzzFrom501To505()
        {
            var result = _fizzBuzzer.FizzBuzzInterval(501, 505);
            result.Should().BeEquivalentTo("Fizz", "502", "503", "Fizz", "Buzz");
        }

        [TestMethod]
        public void FizzBuzzInterval_from_1500_to_1500_should_return_FizzBuzz()
        {
            var result = _fizzBuzzer.FizzBuzzInterval(1500, 1500);
            result.Should().BeEquivalentTo("FizzBuzz");
        }
    }
}
