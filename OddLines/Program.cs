using System.IO;

namespace OddLines
{
    internal class Program
    {
        static void Main()
        {
            string[] text = File.ReadAllLines("input.txt");
            for (int i = 0; i < text.Length; i += 2)
            {
                string line = text[i];
                File.AppendAllText("output.txt", line+"\r\n");
            }
        }
    }
}
