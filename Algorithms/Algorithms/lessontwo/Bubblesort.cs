using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.lessontwo
{
    class Bubblesort
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
            example.Add(50);
            example.Add(40);
            example.Add(140);
            example.Add(45);
            example.Add(30);
            example.Add(24);
            example.Add(250);
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
        public static string BubbleSort()
        {
            //setup
            string text = "";
            List<int> content = GetArray();
            int temp;
            //start
            text = "De array had de volgende sortatie \n";
            text += SetArray(content);
            //Algorithm
            for(int i = 1; i <= content.Count; i++)
            {
                for (int j = (content.Count - 1); j > (i+ 1); j--)
                {
                    if (content[j] < content[j - 1])
                    {
                        temp = content[j];
                        content[j] = content[j - 1];
                        content[j - 1] = temp;
                    }
                }
            }
            //end
            text += "De array heeft nu de volgende sortatie \n";
            text += SetArray(content);
            return text;
        }
    }
}
