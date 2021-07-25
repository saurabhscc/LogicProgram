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
            Console.WriteLine("3 For: Prime Number ");
            Console.WriteLine("4 For: Reverse Number ");
            Console.WriteLine("5 For: Coupon  Number ");
            Console.WriteLine("6 For: Stopwatch  Number ");
            Console.WriteLine("7 For: Vending Machine ");
            Console.WriteLine("8 For: DayOfWeek ");
            Console.WriteLine("9 For: DegreeConversion ");
            Console.WriteLine("10 For: MonthlyPayment ");

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
                case 3:
                    //Prime Number
                   PrimeNumber Primenumber = new PrimeNumber();
                    Primenumber.CheckPrimeNumber();
                    break;
                case 4:
                    //Reverese Number
                    ReverseOfNumber reverseNum = new ReverseOfNumber();
                    reverseNum.ReverseNumber();
                    break;
                case 5:
                    //Coupon Number
                    CopuonNumber CouponNo = new CopuonNumber();
                    CouponNo.Coupons();
                    break;
                case 6:
                    //Stop watch
                    StopWatch Stopwatches = new StopWatch();
                    Stopwatches.stopwatches();
                    break;
                case 7:
                    //Vending Machine
                    VendingMachine Vendingmachine = new VendingMachine();
                    Vendingmachine.CountCurrency();
                        break;
                case 8:
                    //DayOfWeek
                    DayOfWeek dayOfWeek = new DayOfWeek();
                    dayOfWeek.Days();
                    break;
                case 9:
                    //DegreeConversion
                    DegreeConversion degreeConversion = new DegreeConversion();
                    degreeConversion.DegreeConv();
                    break;
                case 10:
                    //MonthlyPayment
                    MonthlyPayment monthlyPayment = new MonthlyPayment();
                    monthlyPayment.Pay();
                    break;
                default:
                    Console.WriteLine("Invalid Selection. Select in b/w  1 - 10");
                    break;
            }
                    Console.ReadLine();
        }
    }
}
