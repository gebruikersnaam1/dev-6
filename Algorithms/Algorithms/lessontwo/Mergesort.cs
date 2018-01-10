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
            example.Add(1);
            example.Add(6);
            example.Add(8);
            example.Add(9);

            example.Add(-4);
            example.Add(0);
            example.Add(10);
            example.Add(100);            
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
        private static List<int> Merge(List<int> A)
        {
            //MERGE-sort (simpel)
            //get the tools
            int i;
            int j;
            int p = 0;
            int r = A.Count;
            int q =  (r / 2) -1;
            int n1 = q + 1;
            int n2 = r - q;
            int[] L = new int[n1 + 10];
            int[] R = new int[n2 + 1];
            //split the array into two
            for( i = 1; i <= n1; i++) {
                L[i] = A[p + i - 1];
              //  Console.WriteLine("Debuglog l: " + L[i]);
            }
            //Console.WriteLine("\n");
            for ( j = 1; j < n2; j++)
            {
                R[j] = A[q+j];
                Console.WriteLine("Debuglog r: " + R[j]);
            }
            //Console.WriteLine("\n");
            i = 1;
            R[5] = int.MinValue; //infinity
            L[5] = int.MaxValue; //infinity
            //Console.WriteLine(R[5]);
            j = 1;
            for (int k = p; k < r; k++)
            {
                //Console.WriteLine("Debuglog k value: "+" i= "+i+" j= "+j+"l = "+L[i]+ " r= "+ R[j]);
                if(L[i] <= R[j])
                {
                    A[k] = L[i];
                  //  Console.WriteLine("Debuglog if: l= " + L[i]);
                    i += 1;
                }
                else
                {
                    A[k] = R[j];
                    //Console.WriteLine("Debuglog else: r= " + R[j]);
                    j += 1;
                }
            }
            return A;
        }
        public static string MergeSort()
        {
            //setup
            string text = "";
            List<int> content = GetArray();
            //start
            text = "De array had de volgende sortatie \n";
            text += SetArray(content);
            //Algorithm
            content = Merge(content);
            //end
            text += "De array heeft nu de volgende sortatie \n";
            text += SetArray(content);
            return text;
        }
    }
}
