// See https://aka.ms/new-console-template for more information

using System;

namespace BYT3_Part_Two
{
    class Program
    {
        static void Main()
        {
            var calc1 = new Calculator(10, 5, "+");
            var calc2 = new Calculator(10, 5, "-");
            var calc3 = new Calculator(10, 5, "*");
            var calc4 = new Calculator(10, 5, "/");
            var calc5 = new Calculator(10, 0, "/"); 
            var calc6 = new Calculator(10, 5, "^");  
            Console.WriteLine($"10 + 5 = {calc1.Calculate()}");
            Console.WriteLine($"10 - 5 = {calc2.Calculate()}");
            Console.WriteLine($"10 * 5 = {calc3.Calculate()}");
            Console.WriteLine($"10 / 5 = {calc4.Calculate()}");
            Console.WriteLine($"10 / 0 = {calc5.Calculate()}");
            Console.WriteLine($"10 ^ 5 = {calc6.Calculate()}");
        }
    }
}