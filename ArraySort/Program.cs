using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вводим массив
            Console.WriteLine("Введите длину массива");
            int a;
            a=Convert.ToInt16(Console.ReadLine());
            int[] array1 = new int[a];
            Console.WriteLine("Вводите элементы по одному используя Enter в качестве разделителя");
            for(int i=0;i<a;i++)
            {
                Console.Write($"array1[{i + 1}]=");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Закончили вводить массив
            int[] array2=new int[a];
            //Восстановление array2 после сортировки
            void Reuse()
            {
                int i = 0;
                foreach (int b in array1)
                {
                    array2[i++] = b;
                }
            }
            //Закончили восстановление
            void OutputArray()
            {
                //Выводим массив
                foreach (int b in array2)
                {
                    Console.Write($"{b} ");
                }
                //Закончили выводить массив
                Console.WriteLine();
            }
            Reuse();
            OutputArray();

            //Сортировка пузырьком
            int a1 = a-1;
            int trans = 0;
            Console.WriteLine("Сортировка пузырьком");
            for (int j = a1; j > 0; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    if (array2[i] > array2[i + 1])
                    {
                        trans = array2[i];
                        array2[i] = array2[i + 1];
                        array2[i + 1] = trans;
                        OutputArray();
                    }

                }
            }
            //Шейкерная сортировка
            Reuse();
            Console.WriteLine("Шейкерная сортировка");
            for (int j1 = a1, j2=0; j1>j2; j1--,j2++)
            {
                for (int i = j2; i < j1; i++)
                {
                    if (array2[i] > array2[i + 1])
                    {
                        trans = array2[i];
                        array2[i] = array2[i + 1];
                        array2[i + 1] = trans;
                        OutputArray();
                    }
                    if (array2[j1-i] < array2[j1-1-i])
                    {
                        trans = array2[j1 - i];
                        array2[j1 - i] = array2[j1 - i - 1];
                        array2[j1 - i - 1] = trans;
                        OutputArray();
                    }
                }
                /* for (int k = j1 - 1; k < j2; k--)
                 {
                     if (array2[k] < array2[k - 1])
                     {
                         trans = array2[k];
                         array2[k] = array2[k - 1];
                         array2[k - 1] = trans;
                         OutputArray();
                     }

                 }*/
            }

            Console.ReadKey();
        }
    }
}
