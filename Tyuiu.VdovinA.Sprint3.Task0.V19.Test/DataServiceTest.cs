using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VdovinA.Sprint3.Task0.V19.Lib;

namespace Tyuiu.VdovinA.Sprint3.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(startValue, stopValue);
            double wait = 4.399; // Исправлено ожидаемое значение

            Assert.AreEqual(wait, res, 0.001);
        }
    }
}