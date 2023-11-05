using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MartysevichAD.Sprint4.Task3.V7.Lib;

namespace Tyuiu.MartysevichAD.Sprint4.Task3.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5] { { 9, 6, 9, 3, 7 }, { 3, 3, 3, 8, 2 }, { 2, 1, 3, 5, 2 }, { 6, 2, 3, 2, 5 }, { 4, 5, 6, 9, 5 } };
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Мартысевич А. Д. | ИИПб-23-3";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема:  Двумерные массивы (статический ввод)                            *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #7                                                             *");
            Console.WriteLine("* Выполнил: Мартысевич Андрей Денисович | ИИПб-23-3                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный       *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 9.                         *");
            Console.WriteLine("* Подсчитайте количество нечетных элементов во всем массиве.             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{ array[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine("Количество нечетных элементов =  " + res);
            Console.ReadKey();
        }
    }
}
