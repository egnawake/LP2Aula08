using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace LINQFluent
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(args[0]);
			
			Console.WriteLine("Lines longer than 30 characters: {0}",
				lines.Count(line => line.Length > 30));
			Console.WriteLine("Average line length: {0}",
				lines.Average(line => line.Length));
			Console.WriteLine("Is there a line longer than 120 characters? {0}",
				lines.Any(line => line.Length > 120) ? "Yes" : "No");
				
			IEnumerable<string> firstWordInYLines =
				from line in lines
				where line.Contains('Y')
				select line.Trim().Split(' ')[0].ToUpper();
				
			Console.WriteLine("First words in lines with a Y");
			foreach (string s in firstWordInYLines)
			{
				Console.WriteLine(s);
			}
        }
    }
}
