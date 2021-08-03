using System;
using System.Collections.Generic;

namespace WordFrequencyUsingHashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            WordCounter("To be or not to be");
        }
        public static void WordCounter(string sentence)
        {
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();
            string[] words = sentence.Split(' ');
            foreach (string elements in words)
            {
                if (wordCounts.ContainsKey(elements))
                {
                    wordCounts[elements] += 1;
                }
                else
                {
                    wordCounts[elements] = 1;
                }
            }
            foreach (string key in wordCounts.Keys)
            {
                Console.WriteLine(key+"-->"+wordCounts[key]);
            }

        }
    }
}
