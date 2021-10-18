using System;

namespace AbstractExample
{
    //------------------------------------------------Error1------------------------
    //public abstract class ClassA
    //{

    //}
    //class Program
    //{
        //static void Main (string[] args)
        //{
            //ClassA classA = new ClassA(); Error: We cant create an instance of the abstract class with the help of "new" 
        //}
    //}

    //-------------------------------------------------------------Error2---------------------------------
    //public abstract class ClassA
    //{
        //public int a;
        //public void XXX()
        //{

        //}
        //abstract public void YYY();
    //}
    //public class ClassB:ClassA
    //{
        //public void YYY() ---- If we use 'public override int YYY() { } ' Error: 'ClassB.YYY()': return type must be 'void' to match overriden member 'ClassA.YYY()'
        //{
        //}

        //}
    //}
    //class Program
    //{
        //static void Main(string[] args)
        //{
            //ClassB classB = new ClassB();
        //}
    //}Error: 'ClassB' does not implement inherited abstract member 'ClassA.YYY()'

    //-------Right use----------------
    public class ClassA
    {
        public virtual void XXX()
        {
            Console.WriteLine("ClassA XXX");
        }
    }
    public abstract class ClassB:ClassA
    {
        public new abstract void XXX();
    }
    public class ClassC:ClassB
    {
        public override void XXX()
        {
            System.Console.WriteLine("ClassC XXX");
        }
    }
    public class Program
    {
        private static void Main(string[] args)
        {
            ClassA classA = new ClassC();
            ClassB classB = new ClassC();
            classA.XXX();
            classB.XXX();

        }
    }
}



