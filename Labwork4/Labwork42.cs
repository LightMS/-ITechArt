using System;

namespace Labwork42
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            var t = a;
            a = b;
            b = t;
        }
        static int[] ShellSort(int[] array)
        {
            //расстояние между элементами, которые сравниваются
            var d = array.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (array[j - d] > array[j]))
                    {
                        Swap(ref array[j], ref array[j - d]);
                        j = j - d;
                    }
                }

                d = d / 2;
            }

            return array;
        }

        static int[] BubbleSort(int[] array)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите элементы массива: ");
            var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var array = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                array[i] = Convert.ToInt32(parts[i]);
            }
            Console.WriteLine("Каким способом вы хотите сделать сортировку? (Введите 1 для сортировки пузырьком и 2 для сортировки Шелла)");
            string Choice = Console.ReadLine();
            while(true)
            {
                Console.WriteLine("Ошибка. Попробуйте ещё раз");
                if (Choice == "1")
                {
                    Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", BubbleSort(array)));
                    break;
                }
                else if (Choice == "2")
                {
                    Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", ShellSort(array)));
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка. Попробуйте ещё раз (Введите 1 для сортировки пузырьком и 2 для сортировки Шелла)");

                }
            }
        }
    }
}