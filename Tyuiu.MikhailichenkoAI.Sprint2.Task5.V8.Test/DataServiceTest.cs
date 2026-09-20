using Tyuiu.MikhailichenkoAI.Sprint2.Task5.V8.Lib;

namespace Tyuiu.MikhailichenkoAI.Sprint2.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            int m = 3; // Март
            int n = 1; // 1-е число

            string res = ds.FindDateOfPreviousDay(m, n);
            string wait = "28.02";

            Assert.AreEqual(wait, res);
        }
    }
}