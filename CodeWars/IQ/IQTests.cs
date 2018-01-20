using NUnit.Framework;
using System;
[TestFixture]
public class IQTests
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(3, IQ.Test("2 4 7 8 10"));
    }

    [Test]
    public void Test2()
    {
        Assert.AreEqual(1, IQ.Test("1 2 2"));
    }

    [Test]
    public void Test3()
    {
        Assert.AreEqual(4, IQ.Test("2 2 2 3"));
    }

    [Test]
    public void Test4()
    {
        Assert.AreEqual(5, IQ.Test("2 2 2 34 35"));
    }

    [Test]
    public void Test5()
    {
        Assert.AreEqual(5, IQ.Test("2 2 2 34 37"));
    }

    [Test]
    public void Test6()
    {
        Assert.AreEqual(5, IQ.Test("4 2 2 34 37"));
    }

    [Test]
    public void Test7()
    {
        Assert.AreEqual(3, IQ.Test("1 1 2 1 1"));
    }
}