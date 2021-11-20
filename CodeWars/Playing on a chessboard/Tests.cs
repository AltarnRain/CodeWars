using System;

using NUnit.Framework;

namespace CodeWars.Playingonachessboard
{
    [TestFixture]
    public class Suite2Tests
    {
        [Test]
        public void Test01()
        {
            Assert.AreEqual("[0]", Suite2.game(0));
        }
        
        [Test]
        public void Test02()
        {
            Assert.AreEqual("[1, 2]", Suite2.game(1));
        }

        [Test]
        public void Test03()
        {
            Assert.AreEqual("[32]", Suite2.game(8));
        }
    }
}

