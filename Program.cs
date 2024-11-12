using System;
namespace PR4_Kolbazov
{
    public class Module
    {
        public int Score { get; private set; }
        public int MaxScore { get; private set; }
        public int MinScore { get; private set; }
        public Module(int score, int minScore, int maxScore)
        {
            MinScore = minScore;
            MaxScore = maxScore;
            if (score < MinScore)
            {
                throw new ArgumentOutOfRangeException("Значение не может быть меньше нуля!");
            }
            if (score > MaxScore)
            {
                throw new ArgumentOutOfRangeException("Превышение максимально допустимых баллов!");
            }
            Score = score;
        }
    }
    public class Sum
    {
        public int Total { get; private set; }
        public Sum(int a, int b, int c)
        {
            if (a > 22 || a < 0 || b > 38 || b < 0 || c > 20 || c < 0)
            {
                throw new Exception("\nПревышено максимальное значение баллов одного или нескольких модулей или какое-либо из них отрецательное!");
            }
            else
            {
                Total = a + b + c;
            }
        }
    }
    public class Calculate
    {
        public int Total { get; private set; }
        public string Str { get; private set; }
        public Calculate(int totalScore)
        {
            Total = totalScore;
            if (totalScore >= 56 && totalScore <= 80)
            {
                Str = "Оценка: \"5\" (Отлично)";
            }
            else if (totalScore >= 32 && totalScore <= 55)
            {
                Str = "Оценка: \"4\" (Хорошо)";
            }
            else if (totalScore >= 16 && totalScore <= 31)
            {
                Str = "Оценка: \"3\" (Удовлетворительно)";
            }
            else if (totalScore >= 0 && totalScore <= 15)
            {
                Str = "Оценка: \"2\" (Неудовлетворительно)";
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 0;
            int a1 = 0;
            int a2 = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("За выполнение заданий модуля 1 «Разработка, администрирование и защита баз данных» студент может получить максимальное количество баллов = 22.\n");
                    Console.Write("Введите количесто баллов: ");
                    if (int.TryParse(Console.ReadLine(), out a))
                    {
                        Module module = new Module(a, 0, 22);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод. Введите числовое значение!\n");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("\nЗа выполнение заданий модуля 2 «Разработка модулей программного обеспечения для компьютерных систем» студент может получить максимум 38 баллов.\n");
                    Console.Write("Введите количесто баллов: ");
                    if (int.TryParse(Console.ReadLine(), out a1))
                    {
                        Module module = new Module(a1, 0, 38);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод. Введите числовое значение!\n");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("\nЗа выполнение заданий модуля 3 «Сопровождение и обслуживание программного обеспечения компьютерных систем» максимальное количество баллов, которое может получить студент, равно 20.\n");
                    Console.Write("Введите количесто баллов: ");
                    if (int.TryParse(Console.ReadLine(), out a2))
                    {
                        Module module = new Module(a2, 0, 20);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод. Введите числовое значение!\n");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            try
            {
                Sum total = new Sum(a, a1, a2);
                Console.WriteLine("");
                Calculate calc = new Calculate(total.Total);
                Console.WriteLine(calc.Str);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}