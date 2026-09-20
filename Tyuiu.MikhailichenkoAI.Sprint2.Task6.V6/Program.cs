using Tyuiu.MikhailichenkoAI.Sprint2.Task6.V6.Lib;
namespace Tyuiu.MikhailichenkoAI.Sprint2.Task6.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Михайличенко А. И. | ИИПБ26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Михайличенко А. И.                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* По заданным номеру масти m (1..4) и номеру достоинства карты k (6..14)  *");
            Console.WriteLine("* определить полное название карты с помощью сокращенной формы switch.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер масти (от 1 до 4): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер достоинства карты (от 6 до 14): ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.FindCardNameAndValue(m, k);

            Console.WriteLine($"Результат: {res}");

            Console.ReadKey();
        }
    }
}
