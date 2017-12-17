using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.lessontwo
{
    class Mergesort
    {
        private static List<int> GetArray()
        {
            List<int> example = new List<int>();
            example.Add(11);
            example.Add(34);
            example.Add(87);
            example.Add(55);
            example.Add(76);
            example.Add(89);
            example.Add(49);
            example.Add(25);
            example.Add(5);
            example.Add(34);
            example.Add(1401);
            example.Add(24);
            example.Add(3);
            example.Add(4);
            example.Add(250);
            example.Add(1);
            example.Add(4321);
            return example;
        }
        private static string SetArray(List<int> content)
        {
            string text = "";
            foreach (int number in content)
            {
                text += number + " ";
            }
            text += "\n";
            return text;
        }
        private static void AlgorithmMergeSort()
        {

        }
        public static string MergeSort()
        {
            //setup
            string text = "";
            List<int> content = GetArray();
            int temp;
            //start
            text = "De array had de volgende sortatie \n";
            text += SetArray(content);
            //Algorithm
            
            //end
            text += "De array heeft nu de volgende sortatie \n";
            text += SetArray(content);
            return text;
        }
    }
}
