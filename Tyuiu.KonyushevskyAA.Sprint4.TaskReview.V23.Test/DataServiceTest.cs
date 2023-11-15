using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KonyushevskyAA.Sprint4.TaskReview.V23.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint4.TaskReview.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int n = 4;
            int m = 3;

            string str = "678135972584";
            int[,] mtrx = new int[n, m];

            int res = ds.Calculate(n, m, str);

            int wait = 5;

            Assert.AreEqual(res, wait);
        }
    }
}
