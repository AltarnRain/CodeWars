﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.MexicanWave
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    class KataTestClass
    {
        [TestCase]
        public void BasicTest1()
        {
            Kata kata = new Kata();
            List<string> result = new List<string> { "Hello", "hEllo", "heLlo", "helLo", "hellO" };
            Assert.AreEqual(result, kata.wave("hello"), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest2()
        {
            Kata kata = new Kata();
            List<string> result = new List<string> { "Codewars", "cOdewars", "coDewars", "codEwars", "codeWars", "codewArs", "codewaRs", "codewarS" };
            Assert.AreEqual(result, kata.wave("codewars"), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest3()
        {
            Kata kata = new Kata();
            List<string> result = new List<string> { };
            Assert.AreEqual(result, kata.wave(""), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest4()
        {
            Kata kata = new Kata();
            List<string> result = new List<string> { "Two words", "tWo words", "twO words", "two Words", "two wOrds", "two woRds", "two worDs", "two wordS" };
            Assert.AreEqual(result, kata.wave("two words"), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest5()
        {
            Kata kata = new Kata();
            List<string> result = new List<string> { " Gap ", " gAp ", " gaP " };
            Assert.AreEqual(result, kata.wave(" gap "), "it should return '" + result + "'");
        }
    }
}
