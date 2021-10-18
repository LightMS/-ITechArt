using System;

namespace PolymorphExample2_4
{
    class Program
    {
        private class Overload
        {

            public void Display()
            {
                //int number = 102;
                //DisplayOverload(40, 1000, number, 4000);
                //Console.WriteLine(number); output: 102
                int[] numbers = { 10, 20, 30 };
                DisplayOverload(40, numbers);
                Console.WriteLine(numbers[1]);//output: 3000
            }

            private void DisplayOverload(int a, params int[] parameterArray)

            {
                parameterArray[1] = 3000;
            }

        }
        static void Main(string[] args)
        {
            var overload = new Overload();
            overload.Display();
        }
    }
}
