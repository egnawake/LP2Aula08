using System;
using System.Text;

namespace ExtendString
{
	public static class StringExtensions
	{
		public static Random rnd;

		static StringExtensions()
		{
			rnd = new Random();
		}

		public static string ToRandomCase(this string s)
		{
			StringBuilder sb = new StringBuilder();

			foreach (char c in s)
			{
				double next = rnd.NextDouble();
				char modifiedChar = next < 0.5
					? Char.ToUpper(c)
					: Char.ToLower(c);
				sb.Append(modifiedChar);
			}

			return sb.ToString();
		}
	}
}