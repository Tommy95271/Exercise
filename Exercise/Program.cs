using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            bool endApp = false;
            while (!endApp)
            {
                Console.WriteLine("It's a change exchanger, there's 1, 5, 10 and 50 denominations, enter your number," +
                    " and it will give you equivalent and as less as denominations.");
                Console.WriteLine("For Example, assume you enter 37, you will receive 3 coins of 10 denomination," +
                    " 1 coin of 5 denomination, and 2 of 1 denomination");
                double ten = 0, five = 0, one = 0, fifty = 0;
                double money = Convert.ToDouble(Console.ReadLine());
                if (money < 50)
                {
                    while (money - 10 >= 0)
                    {
                        ten++;
                        money -= 10;
                    }
                    if ((money % 10) - 5 >= 0)
                    {
                        five++;
                        money -= 5;
                    }
                    while ((money % 10 > 5) || (money % 5 > 0))
                    {
                        one++;
                        money--;
                    }
                    Console.WriteLine($"Coins of Ten dollars : {ten}");
                    Console.WriteLine($"Coins of Five dollars : {five}");
                    Console.WriteLine($"Coins of One dollars : {one}");
                }
                else if (money == 50)
                {
                    fifty++;
                    Console.WriteLine($"Coins of Fifty dollars : {fifty}");
                }
                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;
                Console.ReadLine();
            }
        }
    }
}
