namespace FizzBuzz.Tests
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FizzBuzzPresenterTests
    {
        [TestMethod]
        public void CheckPresenterPresentsSomething()
        {
            var sut = new FizzBuzzPresenter();
            string result = sut.RunFizzBuzzOneToHundred();
            result.Should().NotBeNullOrEmpty();
        }
    }
}