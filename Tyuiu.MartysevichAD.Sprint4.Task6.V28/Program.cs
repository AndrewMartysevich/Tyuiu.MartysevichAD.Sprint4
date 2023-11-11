using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MartysevichAD.Sprint4.Task6.V28.Lib;

namespace Tyuiu.MartysevichAD.Sprint4.Task6.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Мартысевич А. Д. | ИИПб-23-3";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема:  Двумерные массивы (генератор случайных чисел)                   *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #28                                                            *");
            Console.WriteLine("* Выполнил: Мартысевич Андрей Денисович | ИИПб-23-3                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан строковый массив данных                                            *");
            Console.WriteLine("* ['Река', 'Озеро', 'Болото', 'Океан', 'Лужа', 'Море'], используя класс  *");
            Console.WriteLine("* Array, выведите элементы массива, длина которых равна 4 символам.      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            string[] array = new string[] { "Река", "Озеро", "Болото", "Океан", "Лужа", "Море" };
            Console.WriteLine("Исходный массив : ");
            for(int i = 0; i < array.Length - 1;i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("**************************************************************************");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            string[] res = ds.Calculate(array);
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            } 
            Console.ReadKey();
        }
    }
}
