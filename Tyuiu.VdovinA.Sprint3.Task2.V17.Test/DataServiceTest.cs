using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VdovinA.Sprint3.Task2.V17.Lib;

namespace Tyuiu.VdovinA.Sprint3.Task2.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int value = 1;

            double res = ds.GetSumSeries(value);
            double wait = 4.399;

            Assert.AreEqual(wait, res, 0.001);
        }
    }
}