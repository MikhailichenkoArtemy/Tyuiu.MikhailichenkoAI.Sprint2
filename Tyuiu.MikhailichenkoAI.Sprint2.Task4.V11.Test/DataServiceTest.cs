using Tyuiu.MikhailichenkoAI.Sprint2.Task4.V11.Lib;
namespace Tyuiu.MikhailichenkoAI.Sprint2.Task4.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 2;

            double res = ds.Calculate(x, y);
            double wait = 25.000;

            Assert.AreEqual(wait, res);
        }
    }
}
