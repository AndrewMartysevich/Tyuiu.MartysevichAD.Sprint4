using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MartysevichAD.Sprint4.Task2.V30.Lib;

namespace Tyuiu.MartysevichAD.Sprint4.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 1, 6, 3, 7, 5 };
            int res = ds.Calculate(array);
            int wait = 105;
            Assert.AreEqual(wait, res);
        }
    }
}
