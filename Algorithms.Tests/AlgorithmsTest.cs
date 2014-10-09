using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;
namespace Algorithms.Tests
{
    [TestClass]
    public class AlgorithmsTest
    {
        [TestMethod]
        public void MaxMinTest()
        {
            int[] arr = { 12, 1, 56, 7, 3, 2, 89 };
            int max,min ;
            arr.FindMaxMinRecursively(out max, out min);
            int i = max;
            int j = min;
            Assert.AreEqual<int>(89, max);
            Assert.AreEqual<int>(1, min);
        }

        [TestMethod]
        public void EuclideanGCD()
        {
            int first = 12, second = 6;
            Euclidean euclideanCalculator = new Euclidean();
            int gcd = euclideanCalculator.CalculateGCD(first, second);
            Assert.AreEqual<int>(6,gcd);
        }

        [TestMethod]
        public void EuclideanLCM()
        {
            int first = 12, second = 6;
            Euclidean euclideanCalculator = new Euclidean();
            int lcm = euclideanCalculator.CalculateLCM(first, second);
            Assert.AreEqual<int>(12, lcm);
        }


    }
}
