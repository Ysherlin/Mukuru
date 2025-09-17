using Mukuru;

namespace UnitTest
{
    public class UnitTestClass
    {
        private Greeter greeter;

        [SetUp]
        public void Setup()
        {
            greeter = new Greeter();
        }

        [Test]
        public void SayHello_ShouldReturnHelloWorld()
        {
            var result = greeter.SayHello();
            Assert.AreEqual("Hello, World!", result);
        }
    }
}
