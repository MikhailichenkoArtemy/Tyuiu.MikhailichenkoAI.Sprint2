using Tyuiu.MikhailichenkoAI.Sprint2.Task7.V9.Lib;
namespace Tyuiu.MikhailichenkoAI.Sprint2.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 1.5;
            double y = 0.2;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
