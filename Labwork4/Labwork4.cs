using System;
using System.Collections.Generic;

namespace Labwork4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            List<int> FirstMnozh = new List<int>() { 1, 4, 3, 2, 5, 7 };
            List<int> SecondMnozh = new List<int>() { 6, 10, 25, 1, 4, 121 };
            List<int> FinalMnozh = new List<int>();
            foreach (int i in FirstMnozh)
            {
                if (SecondMnozh.Contains(i))
                {
                    FinalMnozh.Add(i);
                }
            }
            foreach (int i in FinalMnozh)
            {
                Console.WriteLine(i);
            }
            //Задание 2
            Queue<int> FirstQueve = new Queue<int>();
            FirstQueve.Enqueue(1);
            FirstQueve.Enqueue(2);
            FirstQueve.Enqueue(0);
            FirstQueve.Enqueue(3);
            FirstQueve.Enqueue(5);
            int min = FirstQueve.Peek();
            int max = FirstQueve.Peek();
            int minind = 0;
            int maxind = 0;
            foreach (int i in FirstQueve)
            {
                if (i < min)
                {
                    min = i;
                    minind = Array.IndexOf(FirstQueve.ToArray(), i);
                }
                else if (i > max)
                {
                    max = i;
                    maxind = Array.IndexOf(FirstQueve.ToArray(), i);
                }
            }
            int sum = 0;
            int[] a = FirstQueve.ToArray();
            for (int i = minind; i <= maxind; i++)
            {
                sum += a[i];
            }
            Console.WriteLine(minind);
            Console.WriteLine(maxind);
            Console.WriteLine(sum);
            // Задание 3
            List<int> HumanNumber = new List<int>();
            int n = 10;
            for (int i = 1; i <= n; i++)
            {
                HumanNumber.Add(i);
            }
            do
            {
                for (int i = 1; i < HumanNumber.Count; i += 2)
                {
                    HumanNumber.RemoveAt(i);
                }
            } while (HumanNumber.Count != 1);

            for (int i = 0; i < HumanNumber.Count; i++)
            {
                Console.WriteLine(HumanNumber[i]);
            }
        }
    }
}