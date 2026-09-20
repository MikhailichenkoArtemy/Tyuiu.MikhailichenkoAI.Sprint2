using Tyuiu.MikhailichenkoAI.Sprint2.Task5.V8.Lib;

namespace Tyuiu.MikhailichenkoAI.Sprint2.Task5.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Михайличенко А. И.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Михайличенко А. И.                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* По заданным натуральным числам n (число) и m (месяц) определить дату    *");
            Console.WriteLine("* предыдущего дня, используя оператор switch.                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите порядковый номер месяца (m): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.FindDateOfPreviousDay(m, n);

            Console.WriteLine($"Дата предыдущего дня: {res}");

            Console.ReadKey();
        }
    }
}
