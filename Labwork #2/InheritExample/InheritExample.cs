using System;

namespace InheritExample
{

    class ClassA : ClassB
    //if we use class ClassA, a.Display1() won't work
    {
        public void Display1()
        {
            Console.WriteLine("ClassA Display1");
            base.Display1();
        }
    }
    class ClassB
    {
        public int x = 100;

        public void Display1()
        {
            Console.WriteLine("ClassB Display1");
        }

        public void Display2()
        {
            Console.WriteLine("ClassB Display2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA();
            a.Display1();
        }
    }
}
    //class Program
    //{
        //static void Main(string[] args)
        //{
            //ClassA b = new ClassB();
            //b.Display2();
        //}
    //}

    //class ClassB
    //{
        //public int x = 100;
        //public void Display1()
        //{
            //Console.WriteLine("ClassB Display1");
        //}
    //}
    
    //class ClassA:ClassB
    //{
        //public void Display2()
        //{
            //Console.WriteLine("ClassA Display2");
        //}
    //} Inheritance here doesn't work because it's the opposite of the original code
    



