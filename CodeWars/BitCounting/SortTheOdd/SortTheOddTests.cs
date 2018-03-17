﻿namespace CodeWars.SortTheOdd

{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SortTheOdds
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new int[] { 1, 3, 2, 8, 5, 4 }, Kata.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
            Assert.AreEqual(new int[] { 1, 3, 5, 8, 0 }, Kata.SortArray(new int[] { 5, 3, 1, 8, 0 }));
            Assert.AreEqual(new int[] { }, Kata.SortArray(new int[] { }));
        }
    }
}