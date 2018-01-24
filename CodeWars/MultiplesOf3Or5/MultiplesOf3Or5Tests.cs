using NUnit.Framework;


namespace MultiplesOf3Or5
{
    [TestFixture]
    public class MultiplesOf3Or5Tests
    {
        [Test]
        public void Test23()
        {
            Assert.AreEqual(23, Kata.Solution(10));
        }
    }
}