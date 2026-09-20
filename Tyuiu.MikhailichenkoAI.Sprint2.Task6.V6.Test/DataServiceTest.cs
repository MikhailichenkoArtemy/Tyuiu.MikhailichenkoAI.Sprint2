using Tyuiu.MikhailichenkoAI.Sprint2.Task6.V6.Lib;

namespace Tyuiu.MikhailichenkoAI.Sprint2.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();

            int m = 1; 
            int k = 12; 

            string res = ds.FindCardNameAndValue(m, k);
            string wait = "дама пик";

            Assert.AreEqual(wait, res);
        }
    }
}