using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MikhailichenkoAI.Sprint2.Task7.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res = (y >= 0) && (y <= 0.5) && (y <= Math.Sin(x)) && (x >= 0) && (x <= Math.PI);

            return res;
        }
    }
}
