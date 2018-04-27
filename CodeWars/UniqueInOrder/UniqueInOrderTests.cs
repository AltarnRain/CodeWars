namespace CodeWars.UniqueInOrder
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class UniqueInOderTests
    {
        [Test]
        public void EmptyTest()
        {
            Assert.AreEqual("", Kata.UniqueInOrder(""));
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual("ABCDAB", Kata.UniqueInOrder("AAAABBBCCDAABBB"));
        }
    }
}