using HelloWorld.Models;
using NUnit.Framework;

namespace HelloWorldTests
{
    [TestFixture]
    public class GivenAPrint
    {
        [Test]
        public void WhenPassingAMessageThenTheCorrectMessageIsReturnedForPrint()
        {
            const string MESSAGE = "HelloWorld";
            var subject = new Print().For(MESSAGE);
            Assert.That(subject, Is.EqualTo(MESSAGE));
        }
    }
}
