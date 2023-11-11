using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MartysevichAD.Sprint4.Task4.V24.Lib;

namespace Tyuiu.MartysevichAD.Sprint4.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 9, 6, 9, 3, 7 }, { 3, 3, 3, 8, 2 }, { 2, 1, 3, 5, 2 }, { 6, 2, 3, 2, 5 }, { 4, 5, 6, 9, 5 } };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = { { 9, 1, 9, 3, 7 }, { 3, 3, 3, 1, 1 }, { 1, 1, 3, 5, 1 }, { 1, 1, 3, 1, 5 }, { 1, 5, 1, 9, 5 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
