using System;

namespace PolymorphExample2_3
{
    class Program
    {
        private class Overload
        {

            public void Display()
            {
                DisplayOverload(100, "200", "300");
                DisplayOverload(200, "100");

                string[] names = { "Akhil", "Ekta", "Arsh" };
                //DisplayOverload(200, names, "Ahile"); Error: cannot convert from 'string[]' to 'string'
                DisplayOverload(200, names);
            }

            private void DisplayOverload(int a, params string[] parameterArray)

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
