namespace FizzBuzz.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FizzBuzzGeneratorTests
    {
        [TestMethod]
        public void CanCreateInstance()
        {
            var fbz = new FizzBuzzGenerator();
        }
    }
}
