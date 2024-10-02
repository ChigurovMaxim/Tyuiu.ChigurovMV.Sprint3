using Tyuiu.ChigurovMV.Sprint3.Task4.V6.Lib;

namespace Tyuiu.ChigurovMV.Sprint3.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            double wait = 8.995;
            double res = ds.Calculate(start, end);
            Assert.AreEqual(wait, res);
        }
    }
}