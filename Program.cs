using System;

namespace Практическое_задание_1_Основы.NET_Смирнов_Денис
{
    class Program
    {
        static void Main(string[] args)
        {
            //Практическое задание 1
            //Задание 1
            int RegionsinBelarus = 6;
            string NameinRussianis = "Имя";
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

            //Задание 2
            int FirstVariable = 1;
            int SecondVariable = 1;
            int Answer = SecondVariable  + ++FirstVariable; //Пример префиксного инкремента (1+(1+1)).
            Console.WriteLine(Answer);
            Answer = SecondVariable + FirstVariable++;//Пример постфиксного инкремента (Пример решается, как 1+2, после чего к FirstVariable прибавляется 1)
            Console.WriteLine(Answer);
            Answer = FirstVariable-- - SecondVariable; //Пример постфиксного декремента(3-1, после чего от First Variable отнимается 1)
            Answer = --FirstVariable - SecondVariable; //Пример префиксного декремента(2-1-1)
            Console.WriteLine(Answer);
            Answer = ++FirstVariable * SecondVariable; //Пример умножения
            Console.WriteLine(Answer);
            Answer = ++FirstVariable / SecondVariable; //Пример деления
            Console.WriteLine(Answer);
            Answer = SecondVariable % FirstVariable; //Пример деления по модулю
            Console.WriteLine(Answer);
            Answer = -Answer; //Пример унарного минуса
            Console.WriteLine(Answer);
            Answer = +Answer; //Пример унарного плюса
            Console.WriteLine(Answer);

            Console.WriteLine(!Amiastudent);//Пример логического НЕ
            Console.WriteLine(Amiastudent == true & SecondVariable == 1);//Пример логического И. Отличается от условного оператора логического И тем, что проверяются оба варианта. Также пример оператора равенства
            Console.WriteLine(Amiastudent == false && SecondVariable==1);//Пример условного оператора логического И. False выдается сразу после проверки первого условия.
            Console.WriteLine(Amiastudent == false | SecondVariable == 1);//Пример логического ИЛИ.
            Console.WriteLine(Amiastudent == true || SecondVariable == 1);//Пример условного оператора логического ИЛИ. Принцип проверки такой же, как и у условного оператора логического И
            Console.WriteLine(Amiastudent != true ^ SecondVariable == 1);//Пример логического исключения ИЛИ. Также пример оператора неравенства
            Console.WriteLine(Eilernumber is int);//Пример is
            Console.WriteLine(Eilernumber as object);//Пример as
            Console.WriteLine((object)NameinRussianis);//пример оператора приведения
        }
    }
}
