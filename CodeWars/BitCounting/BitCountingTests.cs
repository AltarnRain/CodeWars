using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCounting
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class BitCountingTests
    {
        [Test]
        public void CountBits()
        {
            Assert.AreEqual(0, Kata.CountBits(23244));
            Assert.AreEqual(1, Kata.CountBits(4));
            Assert.AreEqual(3, Kata.CountBits(7));
            Assert.AreEqual(2, Kata.CountBits(9));
            Assert.AreEqual(2, Kata.CountBits(10));
        }
    }
}
