namespace CodeWars.SquareIntoSquares
{
    using NUnit.Framework;

    [TestFixture]
    public class DecomposeTests
    {

        [Test]
        public void Test1()
        {
            Decompose d = new Decompose();
            long n = 11;
            Assert.AreEqual("1 2 4 10", d.decompose(n));
        }

        [Test]
        public void Test2()
        {
            Decompose d = new Decompose();
            long n = 50;
            Assert.AreEqual("1 3 5 8 49", d.decompose(n));
        }

        [Test]
        public void Test3()
        {
            Decompose d = new Decompose();
            long n = 49;
            Assert.AreEqual(null, d.decompose(n));
        }
    }

}
