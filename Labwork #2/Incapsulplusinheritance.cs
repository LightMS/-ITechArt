using System;

namespace Incapsulplusinheritance
{
    class Division
    {
        protected int first, second;

        public Division(int a = 0, int b = 0)
        {
            first = a;
            second = b;
        }
        public virtual int Result()
        {
            Console.WriteLine("Parent class area :");
            return 0;
        }
    }
    class NormalDivision : Division
    {
        public NormalDivision(int a = 0, int b = 0) : base(a, b)
        {

        }
        public override int Result()
        {
            Console.WriteLine("Result of division :");
            return (first/second);
        }
    }
    class ModuleDivision : Division
    {
        public ModuleDivision(int a = 0, int b = 0) : base(a, b)
        {
        }
        public override int Result()
        {
            Console.WriteLine("Result of division :");
            return (first%second);
        }
    }
    class Caller
    {
        public void Execution(Division sh)
        {
            int a;
            a = sh.Result();
            Console.WriteLine("Result: {0}", a);
        }
    }
    class Tester
    {
        static void Main(string[] args)
        {
            Caller c = new Caller();
            NormalDivision r = new NormalDivision(100, 10);
            ModuleDivision t = new ModuleDivision(10, 100);

            c.Execution(r);
            c.Execution(t);
            Console.ReadKey();
        }
    }
}
