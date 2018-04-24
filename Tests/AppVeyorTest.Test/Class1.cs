using NUnit.Framework;

namespace AppVeyorTest.Test
{
    [TestFixture]
    public class MyTests
    {
        [Test]
        public void FirstTest()
        {
            var obj = new Class1();
            Assert.IsTrue(obj.Method());
        }

        [Test]
        public void SecondTest()
        {
            var obj = new AppVeyorTestBis.Class1();
            Assert.IsTrue(obj.Method());
        }
    }
}