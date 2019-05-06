using System;

namespace Palindrome.UI
{
    class Program
    {
        static void Main(string[] args)
        {
           // string a = Console.ReadLine();
            string s, revs = "";
            Console.WriteLine("Enter string");
            s= Console.ReadLine();
            for(int i = s.Length - 1; i >= 0; i--)
            {
                revs = revs + s[i].ToString();
            }
            if (revs == s)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("not Palindrome");

            }
            //Console.ReadKey();

        }
    }
}
