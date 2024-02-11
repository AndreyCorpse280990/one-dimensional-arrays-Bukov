using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_dimensional_arrays_Bukov
{
    internal class Program
    {

        private static void Task1()
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[] array2 = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array2[array1.Length - i - 1] = array1[i]; // копирование элементов из array1 в array2 в обратном порядке
            }
            Console.WriteLine($"Изначальный массив: {string.Join(", ", array1)}");
            Console.WriteLine($"Измененный массив: {string.Join(", ", array2)}");
        }

        private static void Task2()
        {
            int[] array3 = { 1, 2, 1, 5, 6, 1, 2, 3, 9 ,3, 3, 7, 8, 2, 3, 0, 6, 5, 6, 7 };
            int[] array4;
            int[] counts = new int[array3.Length]; //массив для подсчета повторений

            for (int i = 0; i < array3.Length; i++)
            {
                counts[array3[i]]++; // ++ счетчик для текущего числа
            }

            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    Console.WriteLine($" '{i}' - {counts[i]}");
                }
            }
        }


        static void Main(string[] args)
        {
            Task2();


        }
    }
}