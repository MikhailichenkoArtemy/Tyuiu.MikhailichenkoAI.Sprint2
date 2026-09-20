using Tyuiu.MikhailichenkoAI.Sprint2.Task3.V30.Lib;

namespace Tyuiu.MikhailichenkoAI.Sprint2.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            double x = 2;
            double res = ds.Calculate(x);
            double wait = 18.000;

            Assert.AreEqual(wait, res);
        }
    }
}