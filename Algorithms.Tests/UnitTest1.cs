using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;
namespace Algorithms.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = { 12, 1, 56, 7, 3, 2, 89 };
            int max,min ;
            arr.FindMaxMinRecursively(out max, out min);
            int i = max;
            int j = min;
        }
    }
}
