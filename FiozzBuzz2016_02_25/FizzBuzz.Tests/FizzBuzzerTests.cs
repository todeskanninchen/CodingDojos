namespace FizzBuzz.Tests
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FizzBuzzerTests
    {
        [TestMethod]
        public void Can_create_FizzBuzzer()
        {
            var fizzBuzzer = new FizzBuzzer();

            fizzBuzzer.Should().NotBeNull();
        }
    }
}
