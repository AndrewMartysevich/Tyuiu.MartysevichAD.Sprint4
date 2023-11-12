using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MartysevichAD.Sprint4.Task7.V15.Lib;

namespace Tyuiu.MartysevichAD.Sprint4.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 4;
            int m = 2;
            int[,] matrix = new int[n, m];
            string value = "10293847";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, value);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
