using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        private FizzBuzz fb;
        private string result;

        
        [TestInitialize]
        public void canCreateClass()
        {
            fb = new FizzBuzz();
            result = "";
        }

        [TestMethod]
        public void canEvaluate()
        {
            result = fb.evaluate(1);
        }

        [TestMethod]
        public void oneReturnsOne()
        {
            result = fb.evaluate(1);
            Assert.AreEqual(result, "1");
        }

        [TestMethod]
        public void twoReturnsTwo()
        {
            result = fb.evaluate(2);
            Assert.AreEqual(result, "2");
        }

        [TestMethod]
        public void threeReturnsFizz()
        {
            result = fb.evaluate(3);
            Assert.AreEqual(result, "Fizz");
        }

        [TestMethod]
        public void fiveReturnsBuzz()
        {
            result = fb.evaluate(5);
            Assert.AreEqual(result, "Buzz");
        }

        [TestMethod]
        public void sixReturnsFizz()
        {
            result = fb.evaluate(6);
            Assert.AreEqual(result, "Fizz");
        }

        [TestMethod]
        public void sevenReturnsSeven()
        {
            result = fb.evaluate(7);
            Assert.AreEqual(result, "7");
        }

        [TestMethod]
        public void nineReturnsFizz()
        {
            result = fb.evaluate(9);
            Assert.AreEqual(result, "Fizz");
        }

        [TestMethod]
        public void tenReturnsBuzz()
        {
            result = fb.evaluate(10);
            Assert.AreEqual(result, "Buzz");
        }

        [TestMethod]
        public void fifteenReturnsFizzBuzz()
        {
            result = fb.evaluate(15);
            Assert.AreEqual(result, "FizzBuzz");
        }

        [TestMethod]
        public void thirtyReturnsFizzBuzz()
        {
            result = fb.evaluate(30);
            Assert.AreEqual(result, "FizzBuzz");
        }

        [TestMethod]
        public void thirtyThreeReturnsFizz()
        {
            result = fb.evaluate(33);
            Assert.AreEqual(result, "Fizz");
        }

    }
}
