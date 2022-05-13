using System;
using System.Linq;

namespace NumericSequence
{
    class Program
    {
        public static int maxNum = 20;
        public static int[] positionarray = new int[maxNum + 1];
        static void Main()
        {
            NextNumbers();
            Console.ReadLine();
         //  findnearest();
        }

        private static void NextNumbers()
        {
            int curNum = 1;
            int count = 1;
          

            while (curNum < maxNum+1)
            {
                for (int i = 0; i < curNum; i++)
                {
                    Console.Write(String.Format("{0}", curNum));
                    positionarray[curNum] = count;
                    count++;

                }
              
                curNum++;
                if (curNum < maxNum+1 & true == false)
                {
                    Console.Write(",");
                }
              
            }
            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
            for (int i = 1; i < positionarray.Length; i++)
            {
                Console.WriteLine(String.Format("{0}: pos {2}-{1}", i, positionarray[i], (positionarray[i]-i+1))
                    );
            }
           

        }
        private static void Findnearest()
        {
            int targetNumber = 20;
            int closest = positionarray.OrderBy(n => Math.Abs(n - targetNumber)).First();
            Console.WriteLine(String.Format("Nearest of {0}, is position {1}, of the number {2}"), targetNumber, closest, 0);
        }
    }
}
