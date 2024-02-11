using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Katas.Tests
{
    [TestClass()]
    public class FizzBuzzTDDTests
    {
        [TestMethod()]
        public void ShowNumberShouldShowNumber1()
        {
            Assert.AreEqual(1,FizzBuzzTDD.ShowNumber(1));
        }
        
        [TestMethod()]
        public void ShowNumberShouldShowFizzWhen6IsPassedAsParameter()
        {
            Assert.AreEqual("Fizz", FizzBuzzTDD.ShowNumber(6));
        }        

        [TestMethod()]
        public void ShowNumberShouldShowBuzzWhen10IsPassedAsParameter()
        {
            Assert.AreEqual("Buzz", FizzBuzzTDD.ShowNumber(10));
        }

        [TestMethod()]
        public void ShowNumberShouldShowFizzBuzzWhen15IsPassedAsParameter()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzzTDD.ShowNumber(15));
        }

        [TestMethod()]
        public void ShowNumberShouldShowFizzBuzzWhen30IsPassedAsParameter()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzzTDD.ShowNumber(30));
        }
               

        [TestMethod()]
        public void FizzBuzzShouldReturnAListWithNumber1and2andFizzWithoutParameter()
        {
            List<object> res = FizzBuzzTDD.FizzBuzz();
            Assert.AreEqual(1, res[0]);
            Assert.AreEqual(2, res[1]);
            Assert.AreEqual("Fizz", res[2]);
        }

        [TestMethod()]
        public void FizzBuzzShouldReturnAListWith100Elements()
        {
            List<object> res = FizzBuzzTDD.FizzBuzz();
            Assert.AreEqual(100, res.Count);
        }

        [TestMethod()]
        public void FizzBuzzShouldReturnBuzzInsteadOfNumber5()
        {
            List<object> res = FizzBuzzTDD.FizzBuzz();
            Assert.AreEqual("Buzz", res[4]);
        }

        [TestMethod()]
        public void FizzBuzzShouldReturnFizzBuzzInsteadOfNumber15()
        {
            List<object> res = FizzBuzzTDD.FizzBuzz();
            Assert.AreEqual("FizzBuzz", res[14]);
        }

    }
}
