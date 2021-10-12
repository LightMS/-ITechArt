using System;

namespace Labwork1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Practical work
            //Task 1
            int RegionsinBelarus = 6;
            string Nameis = "name";
            double Eilernumber = 2.718281828;
            decimal Myaveragemark = 7.9m;
            float Averagetemperature = 36.6f;
            object Transport = "car";
            bool Amiastudent = true;
            char Firstletter = 'A';
            short AmountofyearsAD = 2021;
            long Earthspopulation = 7753000000;
            byte amountofbits = 8;
            ulong NinethMersennePrime = 2305843009213693951;
            ushort SanMarinoPopulation = 33627;

            //task 2
            int FirstVariable = 1;
            int SecondVariable = 1;
            int Answer = SecondVariable + ++FirstVariable; //example of the prefix increment operator(1+(1+1)).
            Console.WriteLine(Answer);
            Answer = SecondVariable + FirstVariable++;//example of the postfix increment operator(1+2, then FirstVariable adds 1)
            Console.WriteLine(Answer);
            Answer = FirstVariable-- - SecondVariable; //example of the postfix decrement operator(3-1, then First Variable decreases by 1)
            Answer = --FirstVariable - SecondVariable; //example of the prefix decrement operator (2-1-1)
            Console.WriteLine(Answer);
            Answer = ++FirstVariable * SecondVariable; //example of the multiplication operator
            Console.WriteLine(Answer);
            Answer = ++FirstVariable / SecondVariable; //example of the division operator
            Console.WriteLine(Answer);
            Answer = SecondVariable % FirstVariable; //example of the remainder operator
            Console.WriteLine(Answer);
            Answer = -Answer; //example of the unary "-" operator
            Console.WriteLine(Answer);
            Answer = +Answer; //example of the unary "+" operator
            Console.WriteLine(Answer);

            Console.WriteLine(!Amiastudent);//example of the logical negation operator
            Console.WriteLine(Amiastudent == true & SecondVariable == 1);//example of the logical AND operator. Checks both conditions. Also the example of the equality operator
            Console.WriteLine(Amiastudent == false && SecondVariable == 1);//example of the conditional logical AND operator. Returns "false" right after checking the first condition(which is false).
            Console.WriteLine(Amiastudent == false | SecondVariable == 1);//example of the logical OR operator.
            Console.WriteLine(Amiastudent == true || SecondVariable == 1);//example of the conditional logical OR operator.
            Console.WriteLine(Amiastudent != true ^ SecondVariable == 1);//example of the logical exclusive OR operator. Also the example of the inequality operator
            Console.WriteLine(Eilernumber is int);//example of is
            Console.WriteLine(Eilernumber as object);//example of as
            Console.WriteLine((object)Nameis);//example of the cast expression operator
            int max = FirstVariable > SecondVariable ? FirstVariable : SecondVariable;//example of the ternary conditional operator
            Console.WriteLine(max);
        }
    }
}