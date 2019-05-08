using System;

namespace Arrayss
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Arrays();
        }
    }
    static void Arrays()
    {
        int[] a = new int[5];
        for(int i=0;i<a.Length;i++)
        {
            a[i] = i * i;
        }
        foreach(var item in a)
        {
            Console.WriteLine(item);
        }
    }
}
