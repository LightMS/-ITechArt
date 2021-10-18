using System;

namespace PolymorphExample1
{
    class Program
    {
        private class Overload
        {
            //Error1
            //public void DisplayOverload() { }
            //public int DisplayOverload() { } Error: Type 'Program.Overload' already defines a member called 'DisplayOverload' with the same parameter types

            //Error2
            //static void DisplayOverload(int a) { }
            //static void DisplayOverload(int a) { }
            //public void DisplayOverload(string a) { } Same mistake as in the first one
            public void DisplayOverload(int a)
            {
                Console.WriteLine($"DisplayOverload:{a}");
            }
            //Error 3
            //private void DisplayOverload(out int a)
            //{
            //a = 100;
            //}
            //private void DisplayOverload(ref int a) { } Error:'Program.Overload' cannot define an overloaded method that differs only on parameter modifiers 'ref' and 'out' 
            public void DisplayOverload(string a)
            {
                Console.WriteLine($"DisplayOverload:{a}");
            }

            //Error 4
            //public void DisplayOverload(int a, string a) { } Error1: the parameter name 'a' is a duplicate
            //public void Display(int a)
            //{
            //string a;
            //}Error2: A local variable named ‘a’ cannot be declared in this scope because it would give a different meaning to ‘a’, which is already used in a ‘parent orcurrent’ scope to denote something else
            public void DisplayOverload(string a, int b)
            {
                Console.WriteLine($"DisplayOverload:{a},{b}");
            }
        }
        static void Main(string[] args)
        {
            var overload = new Overload();
            overload.DisplayOverload(100);
            overload.DisplayOverload("method overloading");
            overload.DisplayOverload("method overloading", 100);
        }
    }
}
//Output: DisplayOverload:100
//DisplayOverload: method overloading
//DisplayOverload: method overloading,100
