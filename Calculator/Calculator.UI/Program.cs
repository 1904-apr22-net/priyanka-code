using System;

namespace Calculator.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n,b,c;
            //int a=3;
            // b = n / a;
            //c = n % a;
            Console.WriteLine("enter an integer");
            string input = Console.ReadLine();
            int num = int.Parse(input);
            Calculator calc = new Calculator();
            calc.Calculator(num);
            
                   
            
        }
    }
}
