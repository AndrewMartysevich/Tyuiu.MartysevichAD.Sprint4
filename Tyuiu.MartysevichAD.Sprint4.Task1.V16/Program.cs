using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MartysevichAD.Sprint4.Task1.V16.Lib;

namespace Tyuiu.MartysevichAD.Sprint4.Task1.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Мартысевич А. Д. | ИИПб-23-3";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема:  Одномерные массивы (ввод с клавиатуры)                          *");
            Console.WriteLine("* Задание #1                                                             *");
            Console.WriteLine("* Вариант #16                                                            *");
            Console.WriteLine("* Выполнил: Мартысевич Андрей Денисович | ИИПб-23-3                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 8                          *");
            Console.WriteLine("* подсчитать произведение нечетных элементов массива.                    *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            int len;
            Console.WriteLine("Введите количество элементов мвссива");
            len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];
            for(int i = 0; i<= len-1;i++)
            {
                Console.Write("Введите значение " + i + " элемента массива:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for(int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine(array[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Произведение нечетных элементов =  " + ds.Calculate(array));
            Console.ReadKey();
        }
    }
}
