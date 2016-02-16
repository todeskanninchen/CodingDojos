namespace FizzBuzz.Tests
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FizzBuzzPresenterTests
    {
        [TestMethod]
        public void CanCreateFizzBuzzPresenter()
        {
            var sut = new FizzBuzzPresenter();

            sut.Should().NotBeNull();
        }
    }
}