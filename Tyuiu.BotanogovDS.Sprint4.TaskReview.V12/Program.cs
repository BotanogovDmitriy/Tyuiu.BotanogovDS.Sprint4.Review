using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BotanogovDS.Sprint4.TaskReview.V12.Lib;

namespace Tyuiu.BotanogovDS.Sprint4.TaskReview.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Ботаногов Д. С. | ИСТНб-23-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Задание TaskReview                                                       *");
            Console.WriteLine("* Вариант #12                                                              *");
            Console.WriteLine("* Выполнил: Ботаногов Дмитрий Сергеевич | ИСТНб-23-1                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, преобразующую строку с числами в матрицу 3х4         *");
            Console.WriteLine("* и подсчитывающую сумму нечетных чисел.                                   *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Строка из одноразрядных цифр [658932125478]                              *");
            Console.WriteLine("****************************************************************************");

            string str = "658932125478";
            
            int n = 3;
            int m = 4;
            int[,] mx = new int[n, m];
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mx[i, j] = int.Parse(str.Substring(i * m + j, 1));
                }
            }

            Console.WriteLine("Матрица: ");
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{mx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Сумма нечетных чисел матрицы =  " + ds.Calculate(n, m, str));
            Console.ReadKey();
        }
    }
}
