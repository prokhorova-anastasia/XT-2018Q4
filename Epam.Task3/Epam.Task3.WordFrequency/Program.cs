using System;
using System.Collections.Generic;
using System.IO;

namespace Epam.Task3.WordFrequency
{
    class Program
    {
        public static void WordFounder(string str, ref Dictionary<string, int> wordFrequency)
        {
            str.ToLower();
            char[] separators = new char[2] { ' ', '.' };
            while (str.Length != 0)
            {
                int i_sep = str.IndexOfAny(separators);
                if (i_sep == -1)
                {
                    i_sep = str.Length;
                }

                if (!wordFrequency.ContainsKey(str.Substring(0, i_sep)))
                {
                    if (str.Substring(0, i_sep) != " ")
                    {
                        wordFrequency.Add(str.Substring(0, i_sep), 1);
                    }
                }
                else
                {
                    wordFrequency[str.Substring(0, i_sep)]++;
                }

                if (i_sep >= str.Length)
                {
                    i_sep = str.Length - 1;
                }

                str = str.Remove(0, i_sep + 1);
            }
        }

        static void Main(string[] args)
        {
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

            StreamReader sr = new StreamReader("input.txt");
            string str = sr.ReadToEnd();
            WordFounder(str, ref wordFrequency);

            foreach (var i in wordFrequency)
            {
                Console.WriteLine("{0} {1}", i.Key, i.Value);
            }
        }
    }
}
