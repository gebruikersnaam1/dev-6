using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.lessonone
{
    class BinarySearch
    {
        private static List<int> GetArray()
        {
            List<int> example = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                example.Add(i);
            }
            return example;
        }
        public static string Binarysearch(int input)
        {
            List<int> n = GetArray();
            int low = 0; int high = n.Count; int middle;
            int x = 0;
            while(low <= high)
            {
                middle = (low + high) / 2;
                Console.WriteLine("After " + x + " low=" + low + " high=" + high + " middle= " + middle);
                if (input < middle)
                    high = middle - 1;
                else if (input > middle)
                    low = middle + 1;
                else
                    return "found " + input;
                //this isn't needed
                x++;
            }
            return input + " not found";
        }
    }
}
