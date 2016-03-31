using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void One()
        {
            Assert.AreEqual("1", 1.FizzBuzz1());
            Assert.AreEqual("1", 1.FizzBuzz2());
        }

        [TestMethod]
        public void Two()
        {
            Assert.AreEqual("2", 2.FizzBuzz1());
            Assert.AreEqual("2", 2.FizzBuzz2());
        }

        [TestMethod]
        public void Three()
        {
            Assert.AreEqual("Buzz", 3.FizzBuzz1());
            Assert.AreEqual("Buzz", 3.FizzBuzz2());
        }

        [TestMethod]
        public void Five()
        {
            Assert.AreEqual("Fizz", 5.FizzBuzz1());
            Assert.AreEqual("Fizz", 5.FizzBuzz2());
        }

        [TestMethod]
        public void Fifteen()
        {
            Assert.AreEqual("FizzBuzz", 15.FizzBuzz1());
            Assert.AreEqual("FizzBuzz", 15.FizzBuzz2());
        }

        [TestMethod]
        public void Zero()
        {
            Assert.AreEqual("FizzBuzz", 0.FizzBuzz1());
            Assert.AreEqual("FizzBuzz", 0.FizzBuzz2());
        }


    }
}
