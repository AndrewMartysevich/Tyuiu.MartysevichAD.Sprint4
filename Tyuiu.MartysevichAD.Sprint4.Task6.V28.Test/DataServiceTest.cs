using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MartysevichAD.Sprint4.Task6.V28.Lib;

namespace Tyuiu.MartysevichAD.Sprint4.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = new string[] { "Река", "Озеро", "Болото", "Океан", "Лужа", "Море" };
            string[] res = ds.Calculate(array);
            string[] wait = { "Река", "Лужа", "Море" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
