using System;
using Algorithms.lessonone;
using Algorithms.lessontwo;

namespace Algorithms
{
    class Program
    {
        static string CreateHeader(string title)
        {
            string header;
            header = "\n\n";
            header += "******************************************************************\n";
            header += "   " + title + "\n";
            header += "******************************************************************\n";
            return header;
        }
        static void Main(string[] args)
        {
            //lesson one
            Console.WriteLine(CreateHeader("Sequential search"));
            Console.WriteLine(SequentialSearch.Sequentialsearch("Tim"));
            Console.WriteLine(CreateHeader("Binary search"));
            Console.WriteLine(BinarySearch.Binarysearch(25));
            //lesson two
            Console.WriteLine(CreateHeader("Insertion sort"));
            Console.WriteLine(Insertionsort.InsertionSort());
            Console.WriteLine(CreateHeader("Bubble sort"));
            Console.WriteLine(Bubblesort.BubbleSort());
            Console.WriteLine(CreateHeader("Merge sort"));
            Console.WriteLine(Mergesort.MergeSort());
            Console.ReadLine();
        }
    }
}
