using System;

namespace Calculator.Library

{
    public class Calculator
    {
        public void Calculator(int n)
        {

            int num = n - (n % 3); ;
            while (num > 3)
            {
                Console.WriteLine(num);
                num -= 3;
            }
        }
    }
}
