using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.lessonone
{
    class SequentialSearch
    {
        private static List<string> GetInput()
        {
            List<string> example = new List<string>();
            example.Add("Tim");
            example.Add("Tom");
            example.Add("Timmy");
            example.Add("Tommy");
            example.Add("Kees");
            example.Add("Koos");
            example.Add("Klaas");
            return example;
        }
        public static string Sequentialsearch(string input)
        {
            List<string> example = GetInput();
            foreach (string i in example)
            {
                if (input == i)
                    return "Found: "+i;
            }
            return input+" is not-found";
        }
    }
}
