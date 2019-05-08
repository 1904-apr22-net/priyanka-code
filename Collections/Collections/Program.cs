using System;
using System.Collections;

namespace Collections
{
    //internal
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 123;
            Random r = new Random();

            //var num2 = 123;
            //var r2 = new Random();
            Arrays();
            list();
            
        }
        //defaut memeber acsee is private
        static void Arrays()
        {
            int[] myNums = new int[5];

            for (int i = 0; i < myNums.length; i++)
            {
                myNums[i] = i * i;
                Console.WriteLine(myNums[i]);
            }
            foreach (var item in myNums)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("elements?");
            var count = int.Parse(Console.ReadLine());
            var array = new int[count];

            var names = new[] { "nick", "fred" };

            int[][] twoD = new int[6][];
            twoD[0] = new int[4];
            twoD[1] = new int[] { 1, 6 };
            twoD[2] = new int[4];
            var x = twoD[0][1];
            int[,] twoDmulti = new int[4, 5];
            twoDmulti[2, 3] = 5;
        }
            static void list()
            {
            ArrayList numList = new ArrayList();
            numList.Add(2);
            numList.Add(5);
            numList.Add(8);
            numList.Remove(8);
            var num = numList[0];

            int num = (int)numList[0];
            object o = new Random();//implicit casting("upcasting")
            //upcasting is implicit
            //bcz evry random can do anything 
            Random r = (Random)o;//downcasting is explicit


            //generic list

            var genericIntList = new ArrayList<int>();
            genericIntList.Add(3);
            var value = genericIntList[0];
        }

        
    }
}
