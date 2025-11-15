using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VdovinA.Sprint3.Task1.V11.Lib;

namespace Tyuiu.VdovinA.Sprint3.Task1.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 0.75;
            int startValue = 1;
            int stopValue = 14;

            double res = ds.GetMultiplySeries(a, startValue, stopValue);
            double wait = 13795.653; // Ожидаемое значение нужно рассчитать

            Assert.AreEqual(wait, res, 0.001);
        }
    }
}