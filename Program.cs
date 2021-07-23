using System;

namespace LogicProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logic Program ");
            Console.WriteLine("1 For: Fibonacci Series ");
            Console.WriteLine("2 For: Perfect Number ");
            int selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    //Fibonacco Series
                    FibbonaciSeries FlibSeries = new FibbonaciSeries();
                    FlibSeries.CheckFibonacciSeries();
                    break;
                case 2:
                    //Perfect Number
                    PerfectNumber PerfectNum = new PerfectNumber();
                    PerfectNum.CheckPerfectNumber();
                    break;
                default:
                    Console.WriteLine("Invalid Selection. Select in b/w  1 and 2");
                    break;
            }
                    Console.ReadLine();
        }
    }
}
