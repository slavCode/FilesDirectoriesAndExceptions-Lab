using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    internal class Program
    {
        static void Main()
        {
            var words = File.ReadAllText("words.txt").ToLower().Split().ToList();
            string[] text = File.ReadAllLines("text.txt");

            Dictionary<string, int> result = new Dictionary<string, int>();
            char[] delimiter = new char[] { ' ', ',', '.', ':', '-', '!', '?' };
            foreach (string word in words)
            {
                result[word] = 0;
            }

            for (int i = 0; i < text.Length; i++)
            {
                string[] wordsFromTxt = text[i].Split(delimiter, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < wordsFromTxt.Length; j++)
                {
                    string word = wordsFromTxt[j].ToLower();
                    if (result.ContainsKey(word))
                    {
                        result[word]++;
                    }
                }
            }

            result = result.OrderByDescending(w => w.Value)
                           .ToDictionary(w => w.Key, w => w.Value);
            foreach (var word in result)
            {
                File.AppendAllText("result.txt", $"{word.Key} - {word.Value}\r\n");
            }
        }
    }
}
