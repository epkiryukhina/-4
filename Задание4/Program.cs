using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание4
{
    class Program
    {
        public static double ImputDouble()//Ввод чисел
        {
            bool rightValue;
            double value;

            do
            {
                string userImput = Console.ReadLine();
                rightValue = double.TryParse(userImput, out value);
                if (!rightValue) Console.Write(@"Ожидалось число. Повторите ввод - ");
            }
            while (!rightValue);

            return value;
        }

        public static double ImputSimple()//Ввод точности
        {
            bool rightValue;
            double value;

            do
            {
                string userImput = Console.ReadLine();
                rightValue = double.TryParse(userImput, out value);
                if (value <= 0) rightValue = false;
                if (!rightValue) Console.Write(@"Ожидалось число. Повторите ввод - ");
            }
            while (!rightValue);

            return value;
        }

        static void Main(string[] args)
        {
            Console.Write(@"Введите точность: ");//Ввод данных
            double e = ImputSimple();
            Console.Write(@"Введите левую границу: ");
            double a = ImputDouble();
            Console.Write(@"Введите правую границу: ");
            double b = ImputDouble();
            double x;

            while (Math.Abs(a + b) < 2 * e)//Решение методом деления пополам
            {
                x = (a + b) / 2;
                if ((Math.Pow(a, 4) + 0.8 * Math.Pow(a, 3) - 0.4 * Math.Pow(a, 2) - 1.4 * a - 1.2) * (Math.Pow(x, 4) + 0.8 * Math.Pow(x, 3) - 0.4 * Math.Pow(x, 2) - 1.4 * x - 1.2) < 0)
                    b = x;
                else if ((Math.Pow(b, 4) + 0.8 * Math.Pow(b, 3) - 0.4 * Math.Pow(b, 2) - 1.4 * b - 1.2) * (Math.Pow(x, 4) + 0.8 * Math.Pow(x, 3) - 0.4 * Math.Pow(x, 2) - 1.4 * x - 1.2) < 0)
                    a = x;
            }

            x = (a + b) / 2;

            Console.WriteLine("Корень: " + x);//Вывод рез-ов
            Console.ReadLine();
        }
    }
}
