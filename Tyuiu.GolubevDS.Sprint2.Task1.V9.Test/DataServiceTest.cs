using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GolubevDS.Sprint2.Task1.V9.Lib;
namespace Tyuiu.GolubevDS.Sprint2.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 1054;
            int y = 375;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] {true, true, true, true, true, false };

            CollectionAssert.AreEqual(wait, res);

        }
    }
}
