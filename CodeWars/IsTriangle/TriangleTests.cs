using NUnit.Framework;
using System;



namespace CodeWars.Triange
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void IsTriangle_ValidPostiveNumbers_ReturnsTrue()
        {
            Assert.IsTrue(Triangle.IsTriangle(5, 7, 10));
        }
    } 
}