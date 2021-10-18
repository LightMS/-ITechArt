using System;

namespace PolymorphExample2_1
{
    class Program
    {
        private class Overload
        {

            public void Display()
            {
                DisplayOverload(100, 200, 300);
                DisplayOverload(200, 100);
                DisplayOverload(200);
            }
            private void DisplayOverload(int a, params int[] parameterArray)

            {
                foreach (var i in parameterArray)
                    Console.WriteLine(i + " " + a);
            }
        }
        static void Main(string[] args)
        {
            var overload = new Overload();
            overload.Display();
        }
    }
}
