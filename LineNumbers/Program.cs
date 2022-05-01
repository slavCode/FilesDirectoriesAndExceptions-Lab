using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace LineNumbers
{
    internal class Program
    {
        static void Main()
        {
            string[] file = File.ReadAllLines("input.txt");
            for (int i = 0; i < file.Length; i++)
            {
                string line = file[i];
                int count = i + 1;
                File.AppendAllText("output.txt", $"{count}. {line}\r\n");
            }
        }
    }
}
