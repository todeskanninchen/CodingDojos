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
        public void FirstElementOfResultShouldBe1()
        {
            var result = _fizzBuzzer.FizzBuzzFrom1To100();
            result[0].Should().Be(1.ToString());
        }

        [TestMethod]
        public void ShouldHave100Elements()
        {
            var result = _fizzBuzzer.FizzBuzzFrom1To100();
            result.Length.Should().Be(100);
        }

        [TestMethod]
        public void FizzBuzzInterval_from_1_to_1_should_return_1()
        {
            var result = _fizzBuzzer.FizzBuzzInterval(1, 1);
            result.Length.Should().Be(1);
            result[0].Should().Be("1");
        }
    }
}
