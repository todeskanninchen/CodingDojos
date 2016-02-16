namespace FizzBuzz.Tests
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FizzBuzzGeneratorTests
    {
        [TestMethod]
        public void CanConvertOne()
        {
            var sut = new FizzBuzzConverter();

            string result = sut.Convert(1);

            result.Should().Be("1");
        }
    }
}
