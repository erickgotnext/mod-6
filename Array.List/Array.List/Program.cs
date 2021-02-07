using System;
using System.Collections.Generic;

namespace Array.List
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[6];

            myArray[0] = 1;
            myArray[1] = 2;
            myArray[2] = 3;
            myArray[3] = 4;
            myArray[4] = 5;
            myArray[5] = 6;

            foreach (var item in myArray)
            {
                Console.WriteLine("Count down:" + item);
            }
            {
                List<int> fives = new List<int>() { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

                for (int i = 0; i < fives.Count; i++)
                {
                    Console.WriteLine(fives[i]);
                }

            }
        }
    }
}
        
    