using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.lessontwo
{
    class Insertionsort
    {
        private static List<int> GetArray()
        {
            List<int> example = new List<int>();
            example.Add(1);
            example.Add(3);
            example.Add(8);
            example.Add(7);
            example.Add(6);
            example.Add(9);
            example.Add(4);
            example.Add(2);
            return example;
        }
        private  static string SetArray(List<int> content)
        {
            string text = "";
            foreach (int number in content)
            {
                text += number + " ";
            }
            text += "\n";
            return text;
        }
        //note the first one doesn't sort
        public static string InsertionSort()
        {
            //setup
            List<int> content = GetArray();
            string text;
            int key;
            int i;
            //start
            text = "De array had de volgende sortatie \n";
            text += SetArray(content);
            //"algoritme"
            for(int j = 2; j < content.Count; j++)
            {
                key = content[j];
                i = j - 1;
                while(i > 0 && content[i] > key)
                {
                    content[i + 1] = content[i];
                    i = i - 1;
                }
                content[i + 1] = key;
            }
            //end
            text += "De array heeft nu de volgende sortatie \n";
            text += SetArray(content);
            return text;
        }
    }
}
